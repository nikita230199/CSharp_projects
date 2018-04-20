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
    public partial class Vklad : Form
    {
        public MainForm mf;
        public bool flag;//истина - добавление записи, ложь - редактирование записи
        public string kod; //kod -для записи кода вклада текущей строки
        public int row; // row - для записи текущей строки
        
        public Vklad()
        {
            InitializeComponent();
        }


        private void Vklad_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'банкиDataSet.Клиенты' table. You can move, or remove it, as needed.
            this.клиентыTableAdapter.Fill(this.банкиDataSet.Клиенты);
            // TODO: This line of code loads data into the 'банкиDataSet1.Открытые_вклады' table. You can move, or remove it, as needed.
            this.открытые_вкладыTableAdapter.Fill(this.банкиDataSet.Открытые_вклады);
            // TODO: This line of code loads data into the 'банкиDataSet.Вклады' table. You can move, or remove it, as needed.
            this.вкладыTableAdapter.Fill(this.банкиDataSet.Вклады);

        }

        //----------------------------------------------------------------------------------------------
        //ВКЛАДКА ОПИСАНИЕ ВКЛАДОВ
        //----------------------------------------------------------------------------------------------
        //добавление записи
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            AddVklad f1 = new AddVklad();
            flag = true;
            f1.vkl = this;
            f1.ShowDialog();
        }

        //редактирование записи
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AddVklad f1 = new AddVklad();
            flag = false;
            kod = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            row = dataGridView1.CurrentRow.Index;
            //передаем данные на форму редактирования
            f1.textBox1.Text = kod;
            f1.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            f1.textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[3].Value.ToString() != "-")
                f1.textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString() != "-")
                f1.textBox6.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            f1.maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            f1.checkBox1.Checked = (bool)dataGridView1.CurrentRow.Cells[6].Value;
            f1.vkl = this;
            f1.ShowDialog();

        }

        // изменение фильтра срока
        private void summa_SelectedIndexChanged(object sender, EventArgs e)
        {

            int minSrok = 0;
            bool p;
            string k;
            p = checkBox1.Checked;
            k = textBox4.Text;
            if (k == "")
            {
                //все записи кроме тех, где минимальный срок имеет значение "-"
                var srok1 = (from q in банкиDataSet.Вклады
                             where q.Минимальный_срок != "-"
                             select new
                             {
                                 q.Код_вклада,
                                 q.Наименование,
                                 q.Минимальная_сумма,
                                 q.Минимальный_срок,
                                 q.Максимальный_срок,
                                 q.Ставка,
                                 q.Возможность_пополнения
                             }
                             );

                //записи отобранные запросом srok1, которые соответсвуют введенным пользователем параметрам
                var srok2 = (from q in srok1
                             where int.Parse(q.Минимальный_срок) <= minSrok
                             && q.Возможность_пополнения == p
                             select new
                             {
                                 q.Код_вклада,
                                 q.Наименование,
                                 q.Минимальная_сумма,
                                 q.Минимальный_срок,
                                 q.Максимальный_срок,
                                 q.Ставка,
                                 q.Возможность_пополнения
                             });
                 var srok5 = (from q in srok1
                             where int.Parse(q.Минимальный_срок) >= minSrok
                             && q.Возможность_пополнения == p
                             select new
                             {
                                 q.Код_вклада,
                                 q.Наименование,
                                 q.Минимальная_сумма,
                                 q.Минимальный_срок,
                                 q.Максимальный_срок,
                                 q.Ставка,
                                 q.Возможность_пополнения
                             });
                //записи, в которых срок "-", в которых возможность добавления равна р
                var srok3 = (from q in банкиDataSet.Вклады
                             where q.Минимальный_срок == "-"
                             && q.Возможность_пополнения == p
                             select new
                             {
                                 q.Код_вклада,
                                 q.Наименование,
                                 q.Минимальная_сумма,
                                 q.Минимальный_срок,
                                 q.Максимальный_срок,
                                 q.Ставка,
                                 q.Возможность_пополнения
                             });


                switch (srok.SelectedIndex)
                {
                    case -1: minSrok = Int32.MaxValue; break;
                    case 0: minSrok = Int32.MaxValue; break;
                    case 1: minSrok = 2; break;
                    case 2: minSrok = 6; break;
                    case 3: minSrok = 12; break;
                    case 4: minSrok = 36; break;
                    case 5: minSrok = 36; break;
                    case 6: dataGridView3.DataSource = srok3.ToList(); break;
                }
                if (srok.SelectedIndex != 6 && srok.SelectedIndex != 5) dataGridView3.DataSource = srok2.Concat(srok3).ToList();
                if (srok.SelectedIndex == 5) dataGridView3.DataSource = srok5.Concat(srok3).ToList();
            }
        }

        //поиск по коду
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                var q1 = (from q in банкиDataSet.Вклады
                          where q.Код_вклада.ToString() == textBox4.Text
                          select new
                             {
                                 q.Код_вклада,
                                 q.Наименование,
                                 q.Минимальная_сумма,
                                 q.Минимальный_срок,
                                 q.Максимальный_срок,
                                 q.Ставка,
                                 q.Возможность_пополнения
                             }).ToList();
                dataGridView3.DataSource = q1;
            }
            else
                dataGridView3.DataSource = вкладыBindingSource;
        }

        //сброс фильтра
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView3.DataSource = вкладыBindingSource;
        }

        //по нажати на ячейке открытых вкладов высвечивается информация о клиенте, которому этот вклад принаджлежит
        private void dataGridView2_CurrentCellChanged(object sender, EventArgs e)
        {
            int m = dataGridView2.CurrentCellAddress.Y;
            if (m != -1)
            {
                //формируем информацию о клиенте
                var query2 = (from cust in банкиDataSet.Клиенты
                              where cust.Код_клиента.ToString() == dataGridView2[3, m].Value.ToString()
                              select cust);
                dataGridView4.DataSource = query2.ToList();
            }
        }
        //поиск по реквизитам клиента
        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            var fam_name = (from cust in банкиDataSet.Клиенты
                            from vklad in банкиDataSet.Открытые_вклады
                            where (cust.Фамилия == textBox6.Text && cust.Имя == textBox3.Text)
                            && (cust.Код_клиента == vklad.Код_клиента)
                            select new
                            {
                                cust.Фамилия,
                                cust.Имя,
                                cust.Отчество,
                                cust.паспорт,
                                vklad.счет,
                                vklad.Дата_открытия,
                                vklad.Срок_мес,
                                vklad.Сумма_вклада,
                                vklad.Дополнительные_взносы,
                                vklad.Общая_сумма,
                                vklad.Капитализация,
                                vklad.Доход
                            });
            var fam_name_otch = (from cust in банкиDataSet.Клиенты
                                 from vklad in банкиDataSet.Открытые_вклады
                                 where (cust.Фамилия == textBox6.Text && cust.Имя == textBox3.Text && cust.Отчество==textBox5.Text)
                                 && (cust.Код_клиента == vklad.Код_клиента)
                                 select new
                                 {
                                     cust.Фамилия,
                                     cust.Имя,
                                     cust.Отчество,
                                     cust.паспорт,
                                     vklad.счет,
                                     vklad.Дата_открытия,
                                     vklad.Срок_мес,
                                     vklad.Сумма_вклада,
                                     vklad.Дополнительные_взносы,
                                     vklad.Общая_сумма,
                                     vklad.Капитализация,
                                     vklad.Доход
                                 }); 

            var pasport = (from cust in банкиDataSet.Клиенты
                           from vklad in банкиDataSet.Открытые_вклады
                           where cust.паспорт == maskedTextBox1.Text && vklad.Код_клиента==cust.Код_клиента
                           select new
                           {
                               cust.Фамилия,
                               cust.Имя,
                               cust.Отчество,
                               cust.паспорт,
                               vklad.счет,
                               vklad.Дата_открытия,
                               vklad.Срок_мес,
                               vklad.Сумма_вклада,
                               vklad.Дополнительные_взносы,
                               vklad.Общая_сумма,
                               vklad.Капитализация,
                               vklad.Доход
                           });
            
            //если заполнена серия+номер паспорта, то ищем по этому полю
            if (maskedTextBox1.MaskCompleted)
            {
                dataGridView5.DataSource = pasport.ToList();
            }
            //иначе ищем по Фамилии и Имени. Если заполнено Отчество, то по ФИО.
            else
            {
                if (textBox6.Text == "" || textBox3.Text == "")
                {
                    MessageBox.Show("Введите фамилию и имя клиента ИЛИ номер паспорта!", "Недостаточно данных!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textBox5.Text == "")
                {
                    dataGridView5.DataSource = fam_name.ToList();
                }
                else
                {
                    dataGridView5.DataSource = fam_name_otch.ToList();
                }
            }
        }

        //сброс фильтра
        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBox3.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox7.Text = "";
            textBox6.Text = "";
            textBox5.Text = "";
            maskedTextBox1.Text = "";
        }
        // поиск по реквизитам вклада
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DateTime d1=dateTimePicker1.Value, 
                d2=dateTimePicker2.Value;
            double minSum=0, maxSum=0;
            int kod=0;
            if (textBox1.Text != "") minSum = double.Parse(textBox1.Text);
            if (textBox2.Text != "") maxSum = double.Parse(textBox2.Text);
            if (textBox7.Text != "") kod = int.Parse(textBox7.Text);
            var p_kod = (from vkl in банкиDataSet.Открытые_вклады
                         where vkl.КВ == kod
                         select new
                           {
                               vkl.счет,
                               vkl.Дата_открытия,
                               vkl.Срок_мес,
                               vkl.Сумма_вклада,
                               vkl.Дополнительные_взносы,
                               vkl.Общая_сумма,
                               vkl.Капитализация,
                               vkl.Доход
                           });
            var p_sum = (from vkl in банкиDataSet.Открытые_вклады
                         where vkl.Дата_открытия>=d1 && vkl.Дата_открытия<=d2 &&
                         double.Parse(vkl.Общая_сумма) >= minSum && double.Parse(vkl.Общая_сумма) <= maxSum
                         select new
                         {
                             vkl.счет,
                             vkl.Дата_открытия,
                             vkl.Срок_мес,
                             vkl.Сумма_вклада,
                             vkl.Дополнительные_взносы,
                             vkl.Общая_сумма,
                             vkl.Капитализация,
                             vkl.Доход
                         });
            var p_date = (from vkl in банкиDataSet.Открытые_вклады
                         where vkl.Дата_открытия >= d1 && vkl.Дата_открытия <= d2
                          select new
                          {
                              vkl.счет,
                              vkl.Дата_открытия,
                              vkl.Срок_мес,
                              vkl.Сумма_вклада,
                              vkl.Дополнительные_взносы,
                              vkl.Общая_сумма,
                              vkl.Капитализация,
                              vkl.Доход
                          });
            if (kod != 0)
            {
                dataGridView5.DataSource = p_kod.ToList();
            }
            else if (maxSum != 0 && minSum != 0)
            {
                dataGridView5.DataSource = p_sum.ToList();
            }
            else
                dataGridView5.DataSource = p_date.ToList();
        }

        //запрет ввода символов
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

        //сохранение 
        private void SaveItem_Click(object sender, EventArgs e)
        {
            вкладыBindingSource.EndEdit();
            вкладыTableAdapter.Update(банкиDataSet.Вклады);
        }

        //открытие вклада
        private void button1_Click(object sender, EventArgs e)
        {               
            var sort = (from p in банкиDataSet.Открытые_вклады
                         orderby p.КОП
                         select p).ToList();
            VRvklad f1 = new VRvklad();
            f1.vkl = this;
            kod = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            f1.ShowDialog();
            if (f1.dob)
            {
                dataGridView2.DataSource = sort;
                int kod_op = int.Parse(dataGridView2[0, dataGridView2.RowCount - 1].Value.ToString()) + 1;
                банкиDataSet.Открытые_вклады.Rows.Add(kod_op, f1.schet, int.Parse(kod),
                    int.Parse(f1.kod_cust),f1.dat,f1.sr, int.Parse(f1.kod_f), f1.sum, f1.plat,
                    f1.o_sum, f1.k, f1.doh);
                открытыевкладыBindingSource.EndEdit();
                открытые_вкладыTableAdapter.Update(банкиDataSet.Открытые_вклады);
                dataGridView2.DataSource = открытыевкладыBindingSource;
                Vklad_Load(this, e);
               MessageBox.Show("Вклад успешно открыт!");
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            вкладыBindingSource.EndEdit();
            вкладыTableAdapter.Update(банкиDataSet.Вклады);
        }


    }

}