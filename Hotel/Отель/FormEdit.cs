using System;
using System.Windows.Forms;

namespace Отель
{
    public partial class FormEdit : Form
    {
        public Form1 form1;
        int reservInt;
        DataGridViewCellCollection cells;
        int i;

        public FormEdit()
        { InitializeComponent(); }

        //--------------------------------------------------
        private void Form3_Load(object sender, EventArgs e)
        {
            cells = form1.dataGridView1.CurrentRow.Cells;
            i = form1.dataGridView1.CurrentRow.Index;

            reservBox.Text = Form1.list[i].Reserv.ToString();  // Лучше работать со списком, чем с DGV.
            //reservBox.Text = cells["reserv"].Value.ToString();

            roomBox.Text = cells["room"].Value.ToString(); 
            surnameBox.Text = (string)cells["surnam"].Value;
            nameBox.Text = (string)cells["name"].Value;
            phoneBox.Text = (string)cells["telefon"].Value;

            checkBoxVIP.Checked = (bool)cells["vIP"].Value;
            checkBoxNON.Checked = (bool)cells["nonGrata"].Value;

            dateTimePicker1.Value = (DateTime)cells["checkInDate"].Value;
            dateTimePicker2.Value = (DateTime)cells["checkOutDate"].Value;
        }


        //--------------------------------------------------
        private void b_Edit_Click(object sender, EventArgs e)
        {
            // Проверяем поле № Брони (reserv).
            if (string.IsNullOrEmpty(reservBox.Text))
            {
                MessageBox.Show("Не задан номер брони. Введите.", "ОШИБКА");
                return;
            }


            if (!int.TryParse(reservBox.Text, out reservInt))
            {
                MessageBox.Show("Номер брони должен иметь цифровой формат. Исправьте.", "ОШИБКА");
                return;
            }

            // Проверяем поле № комнаты (room).
            if (string.IsNullOrEmpty(roomBox.Text))
            {
                MessageBox.Show("Не задан номер комнаты. Введите.", "ОШИБКА");
                return;
            }

            int roomInt;
            if (!int.TryParse(roomBox.Text, out roomInt))
            {
                MessageBox.Show("Номер комнаты должен иметь цифровой формат. Исправьте.", "ОШИБКА");
                return;
            }


            // Проверяем поле Фамилия.
            if (string.IsNullOrEmpty(surnameBox.Text))
            {
                MessageBox.Show("Не введена фамилия. Введите.", "ОШИБКА");
                return;
            }

            // Проверяем поле Имя.
            if (string.IsNullOrEmpty(nameBox.Text))
            {
                MessageBox.Show("Не введено имя. Введите.", "ОШИБКА");
                return;
            }

            // Проверяем поля даты.
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                MessageBox.Show("Дата приезда не может быть позже даты отъезда", "ОШИБКА");
                return;
            }
            Form1.list[i].Reserv = int.Parse(reservBox.Text);
            Form1.list[i].Room = int.Parse(roomBox.Text);
            Form1.list[i].Surname = surnameBox.Text;
            Form1.list[i].Name = nameBox.Text;
            Form1.list[i].Telefon = phoneBox.Text;

            Form1.list[i].VIP = checkBoxVIP.Checked;
            Form1.list[i].NonGrata = checkBoxNON.Checked;

            Form1.list[i].CheckInDate = dateTimePicker1.Value;
            Form1.list[i].CheckOutDate = dateTimePicker2.Value;


            //cells["reserv"].Value = reservBox.Text;
            //cells["room"].Value = roomBox.Text;
            //cells["surnam"].Value = surnameBox.Text;
            //cells["name"].Value = nameBox.Text;
            //cells["telefon"].Value = phoneBox.Text;

            //cells["vIP"].Value = checkBoxVIP.Checked;
            //cells["nonGrata"].Value = checkBoxNON.Checked;

            //cells["checkInDate"].Value = dateTimePicker1.Value;
            //cells["checkOutDate"].Value = dateTimePicker2.Value;


            MessageBox.Show("Клиент " + surnameBox.Text + " отредактирован.");

            Form1.editList = true;

            form1.clientClassBindingSource.ResetBindings(false);
            Close();
        }


        //--------------------------------------------------
        private void b_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
