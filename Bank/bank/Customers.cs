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
    public partial class Customers : Form
    {
        public MainForm mf; 
        public bool flag;//истина - добавление записи, ложь - редактирование записи
        public Customers()
        {
            InitializeComponent();
        }

        private void клиентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.банкиDataSet);

        }

        private void Customers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'банкиDataSet.Клиенты' table. You can move, or remove it, as needed.
            this.клиентыTableAdapter.Fill(this.банкиDataSet.Клиенты);

        }


        //добавление клиента в базу
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.RowCount - 1;
            dataGridView1[0, row].Value = (int.Parse(dataGridView1[0, row - 1].Value.ToString()) + 1).ToString();
        }


        //поиск по реквизитам клиента
        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var fam_name = (from cust in банкиDataSet.Клиенты
                            where cust.Фамилия == textBox3.Text && cust.Имя == textBox4.Text
                            select new
                            {
                                cust.Код_клиента,
                                cust.Фамилия,
                                cust.Имя,
                                cust.Отчество,
                                cust.паспорт
                            });
            var fam_name_otch = (from cust in fam_name
                                 where cust.Отчество == textBox5.Text
                                 select new
                                 {
                                     cust.Код_клиента,
                                     cust.Фамилия,
                                     cust.Имя,
                                     cust.Отчество,
                                     cust.паспорт
                                 });

            var pasport = (from cust in банкиDataSet.Клиенты
                           where cust.паспорт == maskedTextBox1.Text
                           select new
                           {
                               cust.Код_клиента,
                               cust.Фамилия,
                               cust.Имя,
                               cust.Отчество,
                               cust.паспорт
                           });
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

        //сброс фильтра
        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView2.DataSource = клиентыBindingSource;
        }

        
        //проверка правильности введенных значений
        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
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

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            клиентыBindingSource.EndEdit();
            клиентыTableAdapter.Update(банкиDataSet.Клиенты);
        }

    }
}
