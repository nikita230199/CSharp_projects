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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        

        private void button7_Click(object sender, EventArgs e)
        {
            Kredit f1 = new Kredit();
            f1.mf = this;
            f1.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'банкиDataSet.Филиалы' table. You can move, or remove it, as needed.
            this.филиалыTableAdapter.Fill(this.банкиDataSet.Филиалы);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            int row = филиалыDataGridView.RowCount - 1;
            филиалыDataGridView[0, row].Value = (int.Parse(филиалыDataGridView[0, row-1].Value.ToString()) + 1).ToString();
            филиалыDataGridView.CurrentCell = филиалыDataGridView[1, филиалыDataGridView.CurrentCell.RowIndex];
        }

        //проверка заполнения
        private void филиалыDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string value = e.FormattedValue.ToString();
            if (e.ColumnIndex==1)
            {
                if (value =="")
                {
                    MessageBox.Show("Поле адрес не может быть пустым!");
                    e.Cancel=true;
                }
            }
            
        }

        //сохранение
        private void филиалыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            филиалыBindingSource.EndEdit();
            филиалыTableAdapter.Update(банкиDataSet.Филиалы);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Customers f1 = new Customers();
            f1.mf = this;
            f1.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Vklad f1 = new Vklad();
            f1.mf = this;
            f1.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная функция находится в разработке", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
