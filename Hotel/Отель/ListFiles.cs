using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Отель
{
    public partial class ListFiles : Form
    {
        public Form1 form1;
        public ListFiles()
        {
            InitializeComponent();
        }


        //-----------------------------------------------------
        private void ListFiles_Load(object sender, EventArgs e)
        {
            if (Режим.mode == 1)   // Ограниченные возможности.
            {
                CopyButton.Enabled = false;
                DeleteButton.Enabled = false;
            }

            textBox1.Text = Form1.nameFile;

            if (!Directory.Exists(form1.folderClients))
                Directory.CreateDirectory(form1.folderClients);


            // Заполнить список именами всех файлов.
            LoadListBox();
   
        }


        //-----------------------------------------------------
        private void LoadListBox()
        {
            // Заполнить список именами всех файлов.
            listBox1.Items.Clear();

            DirectoryInfo di = new DirectoryInfo(form1.folderClients);
            FileInfo[] files = di.GetFiles();
            if (files.Length == 0)
            {
                button1.Enabled = false;
                CopyButton.Enabled = false;
                DeleteButton.Enabled = false;
            }
            else
            {
                foreach (var item in files)
                    listBox1.Items.Add(item.Name);

                if (files.Length == 1)
                {
                    listBox1.SelectedIndex = 0;
                }
            }

        }


        //-----------------------------------------------------
        private void b_Open_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выделили файл", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Form1.nameFile = (string)listBox1.SelectedItem;
            string currentFile = Path.Combine(form1.folderClients, Form1.nameFile);

            if (currentFile == Form1.pathCurFile)
            {
                MessageBox.Show("Этот файл уже является текущим. Укажите другой файл или закройте окно.",
                            "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Режим.mode == 2 && Form1.pathCurFile != "" && Form1.editList)
            {
                // Сохранить текущий список в текущем файле.

                if (!MySerial<List<ClientClass>>.Serialize(Form1.pathCurFile, Form1.list))   // Сохранить текущий список
                {
                    MessageBox.Show("Открыть файл и загрузить список клиентов не удалось.",
                        "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                    return;

                }
            }


            Form1.pathCurFile = currentFile;

            form1.label3.Text = Form1.nameFile;

            if (Режим.mode == 2)
                form1.b_SaveList.Text = Form1.textButton + " в \"" + Form1.nameFile + "\"";

            if ((Form1.list = MySerial<List<ClientClass>>.Deserialize(Form1.pathCurFile)) == null)
            {
                MessageBox.Show("Открыть файл и загрузить список клиентов не удалось.",
               "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Form1.pathCurFile = "";
                Form1.nameFile = "";
                form1.label3.Text = "";
                form1.b_SaveList.Text = Form1.textButton;

                Close();
                return;
            }

   

            form1.clientClassBindingSource.DataSource = Form1.list;

            Form1.editList = false;
            // Записать в реестр имя выбранного файла в качестве текущего.
            Form1.nameFile = (string)listBox1.SelectedItem;
            MyReg.ValueSet(Form1.nameFile);

            Close();
        }


        //-----------------------------------------------------
        private void b_Copy_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выделили файл", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string selectFile = (string)listBox1.SelectedItem;

            string path = Path.Combine(Environment.CurrentDirectory, form1.folderClients);

            saveFileDialog1.InitialDirectory = path;
            saveFileDialog1.Filter = "XML-файл|*.xml|Все|*.*";
            saveFileDialog1.Title = "Найдите куда и под каким именем скопировать файл " + selectFile;

            saveFileDialog1.FileName = selectFile;

            if(saveFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            try
            {
                if (saveFileDialog1.FileName != "")
                {
                    path = Path.Combine(path, selectFile);

                    File.Copy(path, saveFileDialog1.FileName, true);
                    MessageBox.Show("Файл клиентов:  " + selectFile + "  скопирован в\n" + saveFileDialog1.FileName);

                    LoadListBox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Скопировать файл не удалось. \n\n" + ex.Message, 
                    "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //-----------------------------------------------------
        private void b_Del_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выделили файл", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string currentFile = Path.Combine(form1.folderClients, (string)listBox1.SelectedItem);

            if (currentFile == Form1.pathCurFile)
            {
                MessageBox.Show("Нельзя удалить текущий файл, записи которого отображаются в таблице. Укажите другой файл или закройте окно.",
                            "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string path = Path.Combine(form1.folderClients, (string)listBox1.SelectedItem);
                File.Delete(path);
                MessageBox.Show("Файл: " + (string)listBox1.SelectedItem + "\nУДАЛЕН!" , "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Обновить список файлов.
                LoadListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Удалить файл не удалось. \n\n" + ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
