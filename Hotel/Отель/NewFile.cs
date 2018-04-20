using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Отель
{
    public partial class NewFile : Form
    {
        public Form1 form1;

        public NewFile()
        {
            InitializeComponent();
        }


        //-----------------------------------------------------------
        private void NewFile_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(form1.folderClients))
                Directory.CreateDirectory(form1.folderClients);

            // Заполнить список именами старых файлов.
            LoadListBox();

          
            if (Form1.pathCurFile == "")
            {
                button1.Text = "Выбрать текущим новый файл и выйти";
            }

            // Убрать выделение текста
            textBox1.SelectionStart = 0;
        }

        //-----------------------------------------------------
        private void LoadListBox()
        {
            // Заполнить список именами всех файлов.

            DirectoryInfo di = new DirectoryInfo(form1.folderClients);
            FileInfo[] files = di.GetFiles();

            if (files.Length != 0)
            {
                listBox1.Items.Clear();
                foreach (var item in files)
                    listBox1.Items.Add(item.Name);

                 listBox1.SelectedIndex = listBox1.FindString(Form1.nameFile);
             }

        }

        //-----------------------------------------------------------
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Только текущий файл может быть выделен.
            listBox1.SelectedIndex = listBox1.FindString(Form1.nameFile);
        }

        //-----------------------------------------------------------
        private void b_Create_Click(object sender, EventArgs e)
        {
            if (Path.GetFileNameWithoutExtension(textBox1.Text) == "" )
            {
                MessageBox.Show("Вы не ввели имя нового файла!", "Ошибка!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Path.GetExtension(textBox1.Text) == "") textBox1.Text += ".xml";
            textBox1.Text = textBox1.Text.Trim();

            if (listBox1.FindString(textBox1.Text) > 0)
            {
                MessageBox.Show("Вы ввели имя нового файла, который уже существует!",
                                "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Form1.pathCurFile != "" && Form1.editList)
            {
                    // Запомнить текущих клиентов.
                    if (!MySerial<List<ClientClass>>.Serialize(Form1.pathCurFile, Form1.list))
                    {
                        MessageBox.Show("Текущих клиентов в файле запомнить не удалось!\n" +
                            "Чтобы их не потерять, создание нового файла отменяется.",
                                          "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Close();
                        return;
                    }
            }


            // Запомним в реестре имя нового файла.
            MyReg.ValueSet(textBox1.Text);           
            
            // Новый текущий файл.
            Form1.pathCurFile = Path.Combine(form1.folderClients, textBox1.Text);
            Form1.nameFile = textBox1.Text;
            form1.label3.Text = Form1.nameFile;

            if (Режим.mode == 2)
                form1.b_SaveList.Text = Form1.textButton + " в \"" + Form1.nameFile + "\"";

            Form1.newFile = true;

            Close();
            return;
        }
    }
}
