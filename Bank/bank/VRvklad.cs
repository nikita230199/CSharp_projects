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
    public partial class VRvklad : Form
    {
        public Vklad vkl;
        public bool dob = false, //показывает произошло ли добавление
                    f = true, // true - проверка заполнения данных успешна
                    k;          //для записи капитализации
        public int maxSrok, minSum, maxSum; //
        public string kod_cust, //для записи кода клиента
                      schet,      //для записи счета
                      sr,       //для записи срока вклада
                      plat,     //для записи доп взноса
                      kod_f,    //для записи кода филиала
                      fam,      //для записи фамилии клиента
                      n,        //для записи имени клиента
                      otch,     //для записи отчества клиента
                      pasp,     //для записи паспортных данных клиента
                      sum,      //для записи суммы вклада
                      o_sum,    //для записи общей суммы вклада
                      doh;      //для записи дохода

        public DateTime dat;    //для записи даты оформления кредита

        public VRvklad()
        {
            InitializeComponent();
        }

        private void клиентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.банкиDataSet);

        }

        private void VRvkladcs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'банкиDataSet.Открытые_вклады' table. You can move, or remove it, as needed.
            this.открытые_вкладыTableAdapter.Fill(this.банкиDataSet.Открытые_вклады);
            // TODO: This line of code loads data into the 'банкиDataSet.Счета' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'банкиDataSet.Счета' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'банкиDataSet.Филиалы' table. You can move, or remove it, as needed.
            this.филиалыTableAdapter.Fill(this.банкиDataSet.Филиалы);
            // TODO: This line of code loads data into the 'банкиDataSet.Клиенты' table. You can move, or remove it, as needed.
            this.клиентыTableAdapter.Fill(this.банкиDataSet.Клиенты);
            label1.Text = vkl.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            label8.Text = vkl.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            label14.Text = vkl.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            if ((bool)vkl.dataGridView1.CurrentRow.Cells[6].Value == true)
                panel1.Enabled = true;
            else
                panel1.Enabled = false;
            if (vkl.dataGridView1.CurrentRow.Cells[4].Value.ToString() != "-" 
                && vkl.dataGridView1.CurrentRow.Cells[3].Value.ToString()!="-")
            {
                numericUpDown2.Maximum = decimal.Parse(vkl.dataGridView1.CurrentRow.Cells[4].Value.ToString());
                numericUpDown2.Minimum = decimal.Parse(vkl.dataGridView1.CurrentRow.Cells[3].Value.ToString());
                label6.Text = numericUpDown2.Minimum.ToString();
                label12.Text = numericUpDown2.Maximum.ToString();
            }
            else
            {
                if (vkl.dataGridView1.CurrentRow.Cells[3].Value.ToString() == "-") label6.Text = "не ограничено";
                if (vkl.dataGridView1.CurrentRow.Cells[4].Value.ToString() == "-") label12.Text = "не ограничено";
            }
            comboBox2.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int srok, sum, sum_obsh;
            DateTime d1;
            double proc, plt;
            double dohod;
            srok = (int)numericUpDown2.Value;
            d1 = dateTimePicker4.Value;
            dateTimePicker3.Value = dateTimePicker4.Value.AddMonths(srok);
            if (comboBox2.SelectedIndex != 0 && textBox2.Text != "")
            {
                label16.Text = (srok * int.Parse(textBox2.Text)).ToString();
            }
            else
                label16.Text = "0";

            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите сумму вклада!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                f = false;
            }
            else if (srok==0)
            {
                MessageBox.Show("Введите срок вклада!(срок = 0!)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                f = false;
            }
            else
            {
                if (int.Parse(textBox1.Text) < int.Parse(label8.Text)) textBox1.Text = label8.Text;
                sum = int.Parse(textBox1.Text);
                sum_obsh = sum + int.Parse(label16.Text);
                proc = double.Parse(label14.Text) / 1200;
                if (comboBox2.SelectedIndex == 1 && textBox2.Text != "") plt = double.Parse(textBox2.Text);
                else plt = 0;

                // с капитализацией
                if (checkBox1.Checked)
                {
                    dohod = Math.Round((sum * Math.Pow(1 + proc, srok) + plt * (Math.Pow(1 + proc, srok) - 1) * (1 / proc)) - sum_obsh, 2);
                }
                //без капитализации
                else
                {
                    dohod = Math.Round((sum * (1 + proc * srok) + plt * (Math.Pow(1 + proc, srok) - 1) * (1 / proc)) - sum_obsh, 2);
                }
                label23.Text = (sum_obsh + dohod).ToString();
                label18.Text = sum_obsh.ToString();
                label21.Text = dohod.ToString();
                f = true; //проверка пройдена успешно
            }

        }
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            int row = клиентыDataGridView.RowCount - 1;
            клиентыDataGridView[0, row].Value = (int.Parse(клиентыDataGridView[0, row - 1].Value.ToString()) + 1).ToString();
            клиентыDataGridView.CurrentCell = клиентыDataGridView[1, клиентыDataGridView.CurrentCell.RowIndex];
        }

        private void клиентыDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

            string str, value = e.FormattedValue.ToString();
            str = клиентыDataGridView[e.ColumnIndex, e.RowIndex].Value.ToString();
            switch (e.ColumnIndex)
            {
                case 1:
                    if (value == "")
                    {
                        MessageBox.Show("Поле фамилия не может быть пустым!");
                        e.Cancel = true;
                    }
                    break;
                case 2:
                    if (value == "")
                    {
                        MessageBox.Show("Поле имя не может быть пустым!");
                        e.Cancel = true;
                    }
                    break;
                case 4:
                    if (клиентыBindingSource.Find("паспорт", value) > -1 && value != str)
                    {
                        MessageBox.Show("Серия и номер паспорта не уникальны. Проверьте правильность заполнения");
                        e.Cancel = true;
                    }
                    break;
            }


        }
        // поиск по коду клиента
        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Text != "")
            {
                var q1 = (from str in банкиDataSet.Клиенты
                          where str.Код_клиента.ToString() == toolStripTextBox1.Text
                          select str).ToList();
                клиентыDataGridView.DataSource = q1;
            }
            else
                клиентыDataGridView.DataSource = клиентыBindingSource;
        }

        // поиск по серии паспорта
        private void toolStripTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (toolStripTextBox2.Text != "")
            {
                var q1 = (from str in банкиDataSet.Клиенты
                          where str.паспорт.ToString() == toolStripTextBox2.Text
                          select str).ToList();
                клиентыDataGridView.DataSource = q1;
            }
            else
                клиентыDataGridView.DataSource = клиентыBindingSource;
        }

        private void VRvklad_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dob)
            {
                клиентыBindingSource.EndEdit();
                клиентыTableAdapter.Update(банкиDataSet.Клиенты);
            }
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


        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.Text = "";
            toolStripTextBox2.Text = "";
        }

       

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                textBox2.Text = "";
                textBox2.Enabled = false;
            }
            else
                textBox2.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3_Click(button3, e);
            if (f==true)
            {
                if (textBox3.Text == "" || comboBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Введите №счета и код филиала!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dob = false;
                }
                else if (открытые_вкладыBindingSource.Find("счет",textBox3.Text)>-1) 
                {
                    MessageBox.Show("№счета не уникален!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dob = false;
                }
                else
                {
                    schet = textBox3.Text;
                    kod_cust = клиентыDataGridView.CurrentRow.Cells[0].Value.ToString();
                    dat = dateTimePicker4.Value;
                    sr = numericUpDown2.Value.ToString();
                    kod_f = comboBox1.SelectedValue.ToString();
                    sum = textBox1.Text;
                    plat = label16.Text;
                    o_sum = label18.Text;
                    k = checkBox1.Checked;
                    doh = label21.Text;
                    dob = true;
                    Close();
                }

            }
            
                    
            
            
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}