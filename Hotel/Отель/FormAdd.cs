using System;
using System.Linq;
using System.Windows.Forms;

namespace Отель
{
    public partial class FormAdd : Form
    {
        public Form1 form1;
        int reservInt;

        public FormAdd()
        {  InitializeComponent();  }

        //--------------------------------------------------
        private void Form2_Load(object sender, EventArgs e)
        {
            int max = Form1.list.Max(m => m.Reserv);

            reservBox.Text = (max + 1).ToString();
            reservBox.SelectionStart = 0;
    

            // Избавляемся от времени.
            DateTime dt = DateTime.Now;
            dateTimePicker1.Value = new DateTime(dt.Year, dt.Month, dt.Day);
            dateTimePicker2.Value = dateTimePicker1.Value;
       }


        //--------------------------------------------------
        private void b_Add_Click(object sender, EventArgs e)
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

       
            Form1.list.Add(new ClientClass(reservInt, roomInt, surnameBox.Text, nameBox.Text, dateTimePicker1.Value,
                dateTimePicker2.Value, phoneBox.Text, checkBoxVIP.Checked, checkBoxNON.Checked));

            MessageBox.Show("Клиент " + surnameBox.Text + " добавлен.");

            form1.clientClassBindingSource.ResetBindings(false);
        }


        private void b_Cleare_Click(object sender, EventArgs e)
        {
            reservBox.Text = (reservInt + 1).ToString();
            reservBox.SelectionStart = 0;

            roomBox.Text = "";
            surnameBox.Text = "";
            nameBox.Text = "";
            phoneBox.Text = "";
            checkBoxVIP.Checked = false;
            checkBoxNON.Checked = false;
        }

        //--------------------------------------------------
        private void b_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
