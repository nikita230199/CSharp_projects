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
    public partial class Kredit : Form
    {
        public MainForm mf;
        public bool flag;//истина - добавление записи, ложь - редактирование записи
        public string kod; //kod -для записи кода кредита текущей строки
        public int row; // row- для записи текущей строки
        
        public Kredit()
        {
            InitializeComponent();
        }

        private void Kredit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'банкиDataSet.Кредиты' table. You can move, or remove it, as needed.
            this.кредитыTableAdapter.Fill(this.банкиDataSet.Кредиты);
            // TODO: This line of code loads data into the 'банкиDataSet.Кредиты' table. You can move, or remove it, as needed.
            this.кредитыTableAdapter.Fill(this.банкиDataSet.Кредиты);
            this.клиентыTableAdapter.Fill(this.банкиDataSet.Клиенты);
            выданные_кредитыTableAdapter.Fill(банкиDataSet.Выданные_кредиты);

        }
        //-----------------------------------------------------------------------------------------
        //ВКЛАДКА ВЫДАЧА КРЕДИТА
        //----------------------------------------------------------------------------------------

        //поиск кредита по сумме и/или сроку
        private void summa_SelectedIndexChanged(object sender, EventArgs e)
        {

            int minSum = 0, minSrok = 0;
            switch (srok.SelectedIndex)
            {
                case 0: minSrok = 0; break;
                case 1: minSrok = 1; break;
                case 2: minSrok = 3; break;
                case 3: minSrok = 5; break;
                case 4: minSrok = 15; break;
            }
            switch (summa.SelectedIndex)
            {
                case 0: 
                case 1: minSum = 0; break; 
                case 2: minSum = 1000000; break;
                case 3: minSum = 1500000; break;
                case 4: minSum = 3000000; break;
            }

            var srok1 = (from q in банкиDataSet.Кредиты
                         where int.Parse(q.Максимальный_срок_лет) >= minSrok
                         select new
                         {
                             q.Код_кредита,
                             q.Наименование,
                             q.Минимальная_сумма,
                             q.Максимальная_сумма,
                             q.Ставка,
                             q.Максимальный_срок_лет
                         });

            var sum2 = (from q in банкиDataSet.Кредиты
                        where q.Максимальная_сумма != "-" && int.Parse(q.Максимальная_сумма) >= minSum
                        select new
                         {
                             q.Код_кредита,
                             q.Наименование,
                             q.Минимальная_сумма,
                             q.Максимальная_сумма,
                             q.Ставка,
                             q.Максимальный_срок_лет
                         });

            var sum3 = (from q in банкиDataSet.Кредиты
                        where q.Максимальная_сумма == "-"
                        select new
                        {
                            q.Код_кредита,
                            q.Наименование,
                            q.Минимальная_сумма,
                            q.Максимальная_сумма,
                            q.Ставка,
                            q.Максимальный_срок_лет
                        });

            //если пользователь выбрал оба значения
            if (summa.SelectedIndex >= 0 && srok.SelectedIndex >= 0)
            {
                var q1 = (from p in sum2
                          where int.Parse(p.Максимальный_срок_лет) >= minSrok
                          select p).ToArray();
                var q2 = (from p in sum3
                          where int.Parse(p.Максимальный_срок_лет) >= minSrok 
                          select p).ToArray();
                dataGridView3.DataSource = q1.Concat(q2).ToList();
            }
                //если пользователь выбрал только параметр сумма
            else if (summa.SelectedIndex >= 0 && srok.SelectedIndex == -1)
            {
                dataGridView3.DataSource = sum2.Concat(sum3).ToList();
            }
                //если пользователь выбрал только параметр срок
            else if (summa.SelectedIndex == -1 && srok.SelectedIndex >= 0)
            {
                dataGridView3.DataSource = srok1.ToList();
            }
        }

        //сброс фильтра и вывод всех строк
        private void button2_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.Text = "";
            summa.SelectedIndex = -1;
            srok.SelectedIndex = -1;
            dataGridView3.DataSource = кредитыBindingSource;
        }


        //поиск по коду кредита
        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Text != "")
            {
                var q1 = (from str in банкиDataSet.Кредиты
                          where str.Код_кредита.ToString() == toolStripTextBox1.Text
                          select str).AsDataView();
                dataGridView1.DataSource = q1;
            }
            else
                dataGridView1.DataSource = кредитыBindingSource;
        }

        //добавление кредита
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            AddKredit f1 = new AddKredit();
            f1.kr = this;
            flag = true;
            f1.ShowDialog();

        }
        //редактирование информации о кредите
        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            AddKredit f1 = new AddKredit();
            flag = false;
            f1.kr = this;
            kod = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            row = dataGridView1.CurrentRow.Index;
            f1.textBox1.Text = kod;
            f1.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            f1.textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[3].Value.ToString() != "-")
                f1.textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            f1.maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            f1.textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            f1.ShowDialog();
        }

        // расчет параметров кредита и выдача кредита
        private void button3_Click(object sender, EventArgs e)
        {
            var sort = (from p in банкиDataSet.Выданные_кредиты
                        orderby p.КОП
                        select p).ToList();
            VRkred f1 = new VRkred();
            f1.kr = this;
            kod = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            f1.ShowDialog();
            if (f1.dob)
            {
                dataGridView2.DataSource = sort;
                int kod_op = int.Parse(dataGridView2[0, dataGridView2.RowCount - 1].Value.ToString()) + 1;
                банкиDataSet.Выданные_кредиты.Rows.Add(kod_op, int.Parse(kod), int.Parse(f1.kod_cust), f1.dat, f1.sum, f1.plat, f1.sr, int.Parse(f1.kod_f));
                выданныекредитыBindingSource.EndEdit();
                выданные_кредитыTableAdapter.Update(банкиDataSet.Выданные_кредиты);
                MessageBox.Show("Кредит успешно выдан!");
                dataGridView2.DataSource = выданныекредитыBindingSource;
                Kredit_Load(this, e);
            }
        }

        //------------------------------------------------------------------------------------
        //ВКЛАДКА СВЕДЕНИЯ О ВЫДАННЫХ КРЕДИТАХ
        //------------------------------------------------------------------------------------

        //связываем таблицы "Выданные кредиты", "Кредиты"
        //при смене текущей ячейки в таблице "Выданные кредиты" пользователю выдается информация о кредите.

        private void dataGridView2_CurrentCellChanged(object sender, EventArgs e)
        {
            int m = dataGridView2.CurrentCellAddress.Y;
            if (m != -1)
            {
                //формируем информацию о кредите
                var query1 = (from kredit in банкиDataSet.Клиенты
                              where kredit.Код_клиента.ToString() == dataGridView2[2, m].Value.ToString()
                              select kredit);
                клиентыDataGridView.DataSource = query1.ToList();
            }
        }

        //поиск по реквизитам кредита
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DateTime d1, d2 = new DateTime();
            int minSum = 0, maxSum = 0;
            //сброс фильтра по реквизитам клиента
            d1 = dateTimePicker1.Value;
            d2 = dateTimePicker2.Value;
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            maskedTextBox1.Text = "";

            switch (comboBox1.SelectedIndex)
            {
                case 1: minSum = 0; maxSum = 1000000; break;
                case 2: minSum = 1000000; maxSum = 1500000; break;
                case 3: minSum = 1500000; maxSum = 3000000; break;
                case 4: minSum = 3000000; maxSum = Int32.MaxValue; break;
            }
            var date = (from q in банкиDataSet.Выданные_кредиты
                        where q.Дата_выдачи >= d1
                        select q);
            var date_sum = (from q in date
                            where int.Parse(q.Сумма) >= minSum &&
                            int.Parse(q.Сумма) <= maxSum
                            select q);
            var date_kod = (from q in date
                            where q.КК == int.Parse(textBox6.Text)
                            select q);
            var date_sum_kod = (from q in date_sum
                                where q.КК == int.Parse(textBox6.Text)
                                select q);
            if (comboBox1.SelectedIndex >= 1 && textBox6.Text != "")
                dataGridView2.DataSource = date_sum_kod.ToList();
            else if (comboBox1.SelectedIndex >= 1 && textBox6.Text == "")
                dataGridView2.DataSource = date_sum.ToList();
            else if (comboBox1.SelectedIndex <= 0 && textBox6.Text != "")
                dataGridView2.DataSource = date_kod.ToList();
            else
                dataGridView2.DataSource = date.ToList(); 
        }
        //поиск по реквизитам клиента
        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBox6.Text = "";
            comboBox1.SelectedIndex = -1;
            var fam_name = (from cust in банкиDataSet.Клиенты
                            from kr in банкиDataSet.Выданные_кредиты
                            where cust.Код_клиента==kr.Код_клиента && cust.Фамилия == textBox3.Text && cust.Имя == textBox4.Text
                            select kr);
            var fam_name_otch = (from cust in банкиDataSet.Клиенты
                            from kr in банкиDataSet.Выданные_кредиты
                            where cust.Код_клиента==kr.Код_клиента
                            && cust.Фамилия == textBox3.Text && cust.Имя == textBox4.Text && cust.Отчество == textBox5.Text
                            select kr);

            var pasport = (from cust in банкиDataSet.Клиенты
                           from kr in банкиDataSet.Выданные_кредиты
                           where cust.Код_клиента==kr.Код_клиента && cust.паспорт == maskedTextBox1.Text
                           select kr);
            //если заполнена серия+номер паспорта, то ищем по этому полю
            if (maskedTextBox1.MaskCompleted)
            {
                dataGridView2.DataSource = pasport.ToList();
            }
            //иначе ищем по Фамилии и Имени. Если заполнено Отчество, то по ФИО.
            else
            {
                if (textBox3.Text == "" || textBox4.Text == "")
                {
                    MessageBox.Show("Введите фамилию и имя клиента ИЛИ номер паспорта!", "Недостаточно данных!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textBox5.Text == "")
                {
                    dataGridView2.DataSource = fam_name.ToList();
                }
                else
                {
                    dataGridView2.DataSource = fam_name_otch.ToList();
                }
            }
        }

        // сброс фильтра
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            maskedTextBox1.Text = "";
            textBox6.Text = "";
            comboBox1.SelectedIndex = -1;
            dataGridView2.DataSource = выданныекредитыBindingSource;
        }



        // запрет ввода символов 
        private void КодКредита_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;

        }


        // Запрет ввода пробела 
        private void БезПробелов_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = false;
            if (e.KeyCode == Keys.Space)
                e.SuppressKeyPress = true;
        }



        private void кредитыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.кредитыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.банкиDataSet);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            кредитыBindingSource.EndEdit();
            кредитыTableAdapter.Update(банкиDataSet.Кредиты);
        }





    }
}
