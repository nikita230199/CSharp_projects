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
    public partial class AddKredit : Form
    {
        public Kredit kr;
        public AddKredit()
        {
            InitializeComponent();
        }

        //добавление кредита в список или сохранение изменений
        private void button1_Click(object sender, EventArgs e)
        {
            bool prov = true; //результат проверки истина - проверка пройдена успешно.
            int rez; //переменная для проверки TryParse
            //----------------------------------------------------------------------
            // Проверка корректности данных:
            // поле  "код кредита" - должен быть уникален,
            // поля "наименование", "%ставка", "минимальная сумма", "максимальный срок" - не пустые.
            // максимальная сумма > минимальной суммы
            //-----------------------------------------------------------------------

            //проверка уникальности кода
            if (textBox1.Text == "")            //код кредита не может быть пустым
            {
                MessageBox.Show("Не введен код кредита!", "ОШИБКА!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                prov = false;
            }
            else if (!int.TryParse(textBox1.Text,out rez))
            {
                MessageBox.Show("Введен слишком большой код кредита. Максимальное значение ="+Int32.MaxValue.ToString(), "ОШИБКА!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                prov = false;
            }
            else
            {
                //проверяем наличие такого кода клиента в БД
                if (kr.кредитыBindingSource.Find("Код_кредита", textBox1.Text) > -1)
                {
                    //если пользователь редактирует запись и код клиента соответствует старому коду, то проверка пройдена
                    if ((kr.flag == false) && (textBox1.Text == kr.dataGridView1.CurrentRow.Cells[0].Value.ToString()))
                        prov = true;
                    else
                    {
                        MessageBox.Show("Код кредита не уникален!", "ОШИБКА!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        prov = false;
                    }

                }
            }
         
            //если проверка кода прошла успешно, проверяем заполнение остальных полей
            if (prov == true)
            {
                if ((textBox2.Text == "") || (textBox3.Text == "") || (textBox6.Text == "") || (maskedTextBox1.MaskCompleted == false))
                {
                    MessageBox.Show("Не все обязательные поля заполнены! (обязательные поля отмечены *)", "ОШИБКА!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    prov = false;
                }
                else if (textBox3.Text!="" && (!int.TryParse(textBox3.Text, out rez) || rez > 2000000000))
                {                    
                    MessageBox.Show("Слишком большое значение поля 'Минимальная сумма'. Кредиты свыше 2 000 000 000 руб. не выдаются", "ОШИБКА!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    prov = false;
                }
                else if (textBox4.Text != "" && (!int.TryParse(textBox4.Text, out rez) || rez > 2000000000))
                {
                    MessageBox.Show("Слишком большое значение поля 'Максимальная сумма'. Кредиты свыше 2 000 000 000 руб. не выдаются", "ОШИБКА!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    prov = false;
                }
                else if (!int.TryParse(textBox6.Text, out rez))
                {
                    MessageBox.Show("Слишком большое значение поля 'Максимальная срок'.", "ОШИБКА!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    prov = false;
                }
                else if (textBox4.Text != "" && int.Parse(textBox3.Text) > int.Parse(textBox4.Text))
                {
                    MessageBox.Show("Минимальная сумма больше максимальной!", "ОШИБКА!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    prov = false;
                }

            }

            // Если проверка прошла корректно, добавление/редактирование позиции в БД
            if (prov == true)
            {
                //пользователь добавлял запись
                if (kr.flag)
                {
                    if (textBox4.Text == "")
                        kr.банкиDataSet.Кредиты.Rows.Add(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text,
                        "-", double.Parse(maskedTextBox1.Text).ToString(), textBox6.Text);
                    else
                        kr.банкиDataSet.Кредиты.Rows.Add(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text,
                        textBox4.Text, double.Parse(maskedTextBox1.Text).ToString(), textBox6.Text);
                }

                else
                //пользователь редактировал запись
                {
                    kr.dataGridView1.Rows[kr.row].Cells[0].Value = int.Parse(textBox1.Text);
                    kr.dataGridView1.Rows[kr.row].Cells[1].Value = textBox2.Text;
                    kr.dataGridView1.Rows[kr.row].Cells[2].Value = textBox3.Text;
                    if (textBox4.Text == "")
                        kr.dataGridView1.Rows[kr.row].Cells[3].Value = "-";
                    else
                        kr.dataGridView1.Rows[kr.row].Cells[3].Value = textBox4.Text;
                    kr.dataGridView1.Rows[kr.row].Cells[4].Value = maskedTextBox1.Text;
                    kr.dataGridView1.Rows[kr.row].Cells[5].Value = textBox6.Text;
                }
                kr.кредитыBindingSource.EndEdit();
                kr.кредитыTableAdapter.Update(kr.банкиDataSet.Кредиты);
                Close();
            }
        }

        //отмена добавления/редактирования
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

