using System;
using System.Windows.Forms;

namespace Отель
{
    public partial class Режим : Form
    {
        public static int mode = 0;    // Режим работы: 1 - только просмотр; 2 - всё; 0 - выход.
        public Режим()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //mode = 2;////////////////
            //Close();//////////////
            //return;//////////////

            if (groupBox1.Visible)
            {
                if (textBox1.Text == "123" && textBox2.Text == "123")
                {
                    mode = 2;
                    Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Не верно введен логин или пароль.");
                    textBox1.Focus();
                    return;
                }
            }

            mode = 1;
            Close();
            return;
        }

        //---------------------------------------------------
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Авторизация_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            Text += "    Версия программы " + Form1.vers;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            textBox1.Focus();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }
    }
}
