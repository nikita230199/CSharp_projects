using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bank
{
    public partial class AddVklad : Form
    {
        public Vklad vkl;
        public AddVklad()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool prov = true; //результат проверки истина - проверка пройдена успешно.
            int rez=0; //переменная для проверки TryParse
            //----------------------------------------------------------------------
            // Проверка корректности данных:
            // поле  "код вклада" - должен быть уникален,
            // поля "наименование", "%ставка", "минимальная сумма" - не пустые.
            // максимальный срок > минимального срока
            //-----------------------------------------------------------------------

            //проверка уникальности кода
            if (textBox1.Text == "")            //код вклада не может быть пустым
            {
                MessageBox.Show("Не введен код кредита!", "ОШИБКА!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                prov = false;
            }
            else if (!int.TryParse(textBox1.Text, out rez))
            {
                MessageBox.Show("Введен слишком большой код вклада. Максимальное значение =" + Int32.MaxValue.ToString(), "ОШИБКА!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                prov = false;
            }
            else
            {
                //проверяем наличие такого кода вклада в БД
                if (vkl.вкладыBindingSource.Find("Код_вклада", textBox1.Text) > -1)
                {
                    //если пользователь редактирует запись и код вклада соответствует старому коду, то проверка пройдена
                    if ((vkl.flag == false) && (textBox1.Text == vkl.kod))
                        prov = true;
                    else
                    {
                        MessageBox.Show("Код вклада не уникален!", "ОШИБКА!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        prov = false;
                    }
                }
            }

            //если проверка кода прошла успешно, проверяем заполнение остальных полей
            if (prov == true)
            {
                if ((textBox2.Text == "") || (textBox3.Text == "") || (maskedTextBox1.MaskCompleted == false))
                {
                    MessageBox.Show("Не все обязательные поля заполнены! (обязательные поля отмечены *)", "ОШИБКА!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    prov = false;
                }
                else if (!int.TryParse(textBox3.Text, out rez) || rez > 2000000000)
                {
                    MessageBox.Show("Слишком большое значение поля 'Минимальная сумма'. Вклады не больше 2 000 000 000 руб.", "ОШИБКА!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    prov = false;
                }
                else if (textBox4.Text != "" && (!int.TryParse(textBox4.Text, out rez) || rez > 2000000000))
                {
                    MessageBox.Show("Слишком большое значение поля 'Максимальная сумма'. Вклады не больше 2 000 000 000 руб.", "ОШИБКА!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    prov = false;
                }
                else if (textBox6.Text != "" && !int.TryParse(textBox6.Text, out rez))
                {
                    MessageBox.Show("Слишком большое значение поля 'Максимальный срок'.", "ОШИБКА!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    prov = false;
                }
                else if ((textBox4.Text!="" && textBox6.Text=="" )|| (textBox4.Text!="" && textBox6.Text!="" && int.Parse(textBox4.Text) > int.Parse(textBox6.Text)))
                {
                    MessageBox.Show("Минимальный срок больше максимального!", "ОШИБКА!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    prov = false;
                }

            }

            // Если проверка прошла корректно, добавление/редактирование позиции в БД
            if (prov == true)
            {
                if (textBox4.Text == "") textBox4.Text = "-";
                if (textBox6.Text == "") textBox6.Text = "-";
                //пользователь добавлял запись
                if (vkl.flag)
                {
                       vkl.банкиDataSet.Вклады.Rows.Add(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text,
                        textBox4.Text,textBox6.Text, double.Parse(maskedTextBox1.Text).ToString(), checkBox1.Checked);
                }
                else
                //пользователь редактировал запись
                {
                    vkl.dataGridView1.Rows[vkl.row].Cells[0].Value = int.Parse(textBox1.Text);
                    vkl.dataGridView1.Rows[vkl.row].Cells[1].Value = textBox2.Text;
                    vkl.dataGridView1.Rows[vkl.row].Cells[2].Value = textBox3.Text;
                    vkl.dataGridView1.Rows[vkl.row].Cells[3].Value = textBox4.Text;
                    vkl.dataGridView1.Rows[vkl.row].Cells[4].Value = textBox6.Text;
                    vkl.dataGridView1.Rows[vkl.row].Cells[5].Value = maskedTextBox1.Text;
                    vkl.dataGridView1.Rows[vkl.row].Cells[6].Value = checkBox1.Checked;                    
                }
                vkl.вкладыBindingSource.EndEdit();
                Close();
            }

        }

        //отмена добавления
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        void КодКредита_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;

        }


        // Запрет ввода пробела поля минимальная сумма, максимальная сумма, максимальный срок, код кредита
        void БезПробелов_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = false;
            if (e.KeyCode == Keys.Space)
                e.SuppressKeyPress = true;
        }
    }
}
