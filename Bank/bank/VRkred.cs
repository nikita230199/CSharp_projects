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
    public partial class VRkred : Form
    {
        public Kredit kr;
        public bool flag,//истина - добавление записи, ложь - редактирование записи
                    f = true, // true - проверка заполнения данных успешна
                    dob = false; //true - произошло добвление
        int maxSrok, minSum, maxSum; //
        public string kod_cust, //для записи кода клиента
                      kod_kred, //для записи кода кредита
                      sum,      //для записи суммы кредита
                      sr,       //для записи срока кредитования
                      plat,     //для записи ежемесячного платежа
                      kod_f,    //для записи кода филиала
                      fam,      //для записи фамилии клиента
                      n,        //для записи имени клиента
                      otch,     //для записи отчества клиента
                      pasp;     //для записи паспортных данных клиента
        public DateTime dat;    //для записи даты оформления кредита
        public VRkred()
        {
            InitializeComponent();
        }
        private void VRkred_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'банкиDataSet.Филиалы' table. You can move, or remove it, as needed.
            this.филиалыTableAdapter.Fill(this.банкиDataSet.Филиалы);
            // TODO: This line of code loads data into the 'банкиDataSet.Клиенты' table. You can move, or remove it, as needed.
            this.клиентыTableAdapter.Fill(this.банкиDataSet.Клиенты);
            //
            maxSrok = int.Parse(kr.dataGridView1.CurrentRow.Cells[5].Value.ToString());
            minSum = int.Parse(kr.dataGridView1.CurrentRow.Cells[2].Value.ToString());
            if (!int.TryParse(kr.dataGridView1.CurrentRow.Cells[3].Value.ToString(), out maxSum))
            {
                label9.Text = "не определено";
                maxSum = Int32.MaxValue;
            }
            else
            {
                label9.Text = maxSum.ToString();
            }
            label1.Text = kr.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            label14.Text = kr.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            label8.Text = minSum.ToString();
            numericUpDown1.Maximum = maxSrok;
        }

        // расчет кредита
        private void button3_Click(object sender, EventArgs e)
        {
            int sum;
            double srok, plt, proc;
            
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите сумму кредита!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                f = false;
            }
            else if (numericUpDown1.Value == 0 && numericUpDown2.Value == 0)
            {
                MessageBox.Show("Введите срок кредитования!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                f = false;
            }
            else
            {
                if (!int.TryParse(textBox1.Text, out sum))
                    sum = maxSum + 1;
                proc = double.Parse(label14.Text) / 1200;
                if (sum > maxSum)
                    textBox1.Text = maxSum.ToString();
                else if (sum < minSum)
                    textBox1.Text = minSum.ToString();
                srok = (int)(numericUpDown1.Value * 12 + numericUpDown2.Value);
                sum = int.Parse(textBox1.Text);
                label13.Text = (srok).ToString();
                dateTimePicker2.Value = dateTimePicker1.Value.AddMonths((int)srok);
                // расчет ежемесячного платежа
                plt = Math.Round(sum * (proc + (proc / (Math.Pow((1 + proc), (double)srok) - 1))), 2);
                label17.Text = plt.ToString();
                // расчет переплаты по кредиту
                label18.Text = Math.Round(plt * srok - sum, 2).ToString();
                f = true;
            }
        }

        // выдача кредита
        private void button2_Click(object sender, EventArgs e)
        {
            button3_Click(button3, e);
            if (f == true)
            {
                if (dataGridView1.CurrentRow.Index == -1)
                {
                    MessageBox.Show("Выберите клиента из списка или добавьте нового.");
                }
                else if (comboBox1.Text == "")
                {
                    MessageBox.Show("Введите код филиала!");
                }
                else
                {
                    //передаем необходимые данные
                    kod_cust = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    sum = textBox1.Text;
                    sr = label13.Text;
                    dat = dateTimePicker1.Value;
                    plat = label17.Text;
                    kod_f = comboBox1.Text;
                    fam = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    n = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    otch = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    pasp = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    dob = true;
                    Close();
                }
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
                dataGridView1.DataSource = q1;
            }
            else
                dataGridView1.DataSource = клиентыBindingSource;
        }

        // поиск по серии паспорта
        private void toolStripTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (toolStripTextBox2.Text != "")
            {
                var q1 = (from str in банкиDataSet.Клиенты
                          where str.паспорт.ToString() == toolStripTextBox2.Text
                          select str).ToList();
                dataGridView1.DataSource = q1;
            }
            else
                dataGridView1.DataSource = клиентыBindingSource;
        }




        //запрет ввода символов
        void КодКлиента_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;

        }


        // Запрет ввода пробела поля код клиента
        void БезПробелов_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = false;
            if (e.KeyCode == Keys.Space)
                e.SuppressKeyPress = true;
        }

        // добавление записи (установка кода клиента)
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.RowCount - 1;
            dataGridView1[0, row].Value = (int.Parse(dataGridView1[0, row - 1].Value.ToString()) + 1).ToString();
            dataGridView1.CurrentCell = dataGridView1[1, dataGridView1.CurrentCell.RowIndex];
        }

        //проверка заполнения данных при добавлении и редактировании
        private void клиентыDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string str, value = e.FormattedValue.ToString();
            str = dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
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

        // сохранение клиента
        private void клиентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            клиентыBindingSource.EndEdit();
            клиентыTableAdapter.Update(банкиDataSet.Клиенты);
            kr.dataGridView2.DataSource = kr.выданныекредитыBindingSource;
            kr.клиентыDataGridView.DataSource = kr.клиентыBindingSource1;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.Text = "";
            toolStripTextBox2.Text = "";
        }

        private void VRkred_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dob)
            {
                клиентыBindingSource.EndEdit();
                kr.клиентыBindingSource1.EndEdit();
                клиентыTableAdapter.Update(банкиDataSet.Клиенты);
                kr.dataGridView2.DataSource = kr.выданныекредитыBindingSource;
                kr.клиентыDataGridView.DataSource = kr.клиентыBindingSource1;
            }

        }

        //ограничение по максимальному сроку
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == numericUpDown1.Maximum)
            {
                numericUpDown2.Value = 0;
                numericUpDown2.Enabled = false;
            }
            else
                numericUpDown2.Enabled = true;
        }

    }
}
