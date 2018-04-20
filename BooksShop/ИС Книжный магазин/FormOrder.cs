using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ИС_Книжный_магазин
{
    public partial class FormOrder : Form
    {
        Catalog catalog1;//Родительская форма Каталог, из которой вызывается данная форма
        Order currentOrder;//Объект класса Order, в котором содержится вся информация о текущем заказе
        List<OrderedBook> ListOrderedBook = new List<OrderedBook>();
        BinaryFormatter bf = new BinaryFormatter();//Объект для сериализации и десериализации
        uint sum //Сумма заказа
        {
            get
            {
                uint s = 0;
                for (int i = 0; i < ListOrderedBook.Count; i++)
                    s += ListOrderedBook[i].price * ListOrderedBook[i].number;
                return s;
            }
        }

        public FormOrder()
        {
            InitializeComponent();
        }

        public FormOrder(Catalog c1)
        {
            InitializeComponent();
            catalog1 = c1; //Инициализируется текущая форма каталога
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            //При загрузке формы заказов в заказ добавляются выделенные строки с книгами из формы Catalog
            int length = catalog1.dataGridViewCatalog.SelectedRows.Count; //Количество выделенных книг
            if (length > 0)//Выделена хотя бы одна книга
                for (int i = 0; i < length; i++)
                    //Книги добавляются в dataGridViewOrder вместе с количеством каждой по умолчанию, равными 1
                    ListOrderedBook.Add(new OrderedBook(catalog1.ListBook[catalog1.dataGridViewCatalog.SelectedRows[i].Index], 1));
            else //Не выделено ни одной книги
            {
                MessageBox.Show("Для заказа книги необходимо выделить полностью строку, содержащую необходимую книгу.\nДля этого нажмите на самую левую пустую колонку в таблице, и строка выделится сама.", "Ошибка заказа");
                Close();
            }

            orderedBooksBindingSource.DataSource = ListOrderedBook;

            //По умолчанию ФИО заказчика заполняется из информации о пользователе. В процессе заказа ФИО можно изменить
            textBoxSurname.Text = catalog1.start1.currentUser.userSurname;
            textBoxFirstName.Text = catalog1.start1.currentUser.userFirstName;
            textBoxMiddleName.Text = catalog1.start1.currentUser.userMiddleName;
            //Дата и сумма заказа устанавливаются автоматически и их изменить пользователь не может
            textBoxOrderDate.Text = DateTime.Today.ToShortDateString();
            textBoxOrderSum.Text = sum.ToString();

            //При помощи предиката и поиска вычисляется номер текущего заказа по формуле = текущая дата + количество заказов за сегодня + 1
            Predicate<Order> predicate = Find;
            int n = catalog1.ListOrder.FindAll(predicate).Count+1;//Количество заказов за текущую дату + 1
            textBoxOrderNumber.Text = DateTime.Today.ToString("ddMMyyyy" + n.ToString("00000"));
        }

        private static bool Find(Order obj)
        {
            //Метод для создания предиката
            return (obj.date.Date == DateTime.Today.Date);
        }

        private void buttonLoadOut_Click(object sender, EventArgs e)
        {
            //Происходит при нажатии кнопки Выгрузить чек
            if (currentOrder == null)//Если заказ ещё не заказан
                MessageBox.Show("Для получения чека необходимо сначала произвести заказ книги.", "Ошибка заказа");
            else if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                currentOrder.LoadOut(saveFileDialog1.FileName);
        }

        private void radioButtonDelivery_CheckedChanged(object sender, EventArgs e)
        {
            //Если выбрана опция - доставка, то поле адреса становится доступным пользователю. Если нет - то не доступно
            textBoxAdress.Enabled = radioButtonDelivery.Checked;
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            //При нажатии на кнопку Заказать, происходит оформление заказа
            if (textBoxOrderSum.Text == "0")
                MessageBox.Show("Вы ничего не заказали. Укажите, пожалуйста, в столбце 'Количество' необходимое количество книг.", "Ошибка заказа");
            else if (!maskedTextBoxPhone.MaskFull)
                MessageBox.Show("Пожалуйста, заполните графу 'Телефон', чтобы наш сотрудник мог с Вами связаться.", "Ошибка заказа");
            else
            {
                //Создается новый заказ и добавляется в список заказов
                currentOrder = new Order(textBoxOrderNumber.Text, ListOrderedBook, catalog1.start1.currentUser, textBoxSurname.Text, textBoxFirstName.Text, textBoxMiddleName.Text, maskedTextBoxPhone.Text, radioButtonDelivery.Checked, textBoxAdress.Text);

                bool checkPresence = true;//Логическая переменная обозначающая есть ли заказанные книги в наличии
                string message = "";
                foreach (OrderedBook b in currentOrder.orderedBooks)
                    if (b.number > b.shop) checkPresence = false;//Если хоть одной книги нет в наличии в достаточном количестве, переменная принимает значение false

                if (radioButtonDelivery.Checked)
                    //Если все книги есть в наличии тогда доставка производится быстрее
                    if (checkPresence)  message = "Ваш заказ оформлен. \nБудет доставлен в течение одного-двух рабочих дней.";
                    else message = "Ваш заказ оформлен. \nБудет доставлен в течение двух-трех рабочих дней.";
                else 
                    if (checkPresence) message = "Ваш заказ оформлен. \nВы можете забрать его в магазине в любое удобное для Вас время.";
                    else message = "Ваш заказ оформлен. \nВы можете забрать его в магазине в любое удобное для Вас время, начиная с завтрашнего дня.";
                message += "\nДля изменения информации о заказе перейдите во вкладку 'Мои заказы'.";
                MessageBox.Show(message, "Заказ оформлен");//Сообщение выводится пользователю
            }
        }

        private void FormOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Если что-то было заказано, то происходит обновление списков и запись их в файл.
            if (currentOrder != null)
            {
                catalog1.ListOrder.Add(currentOrder);
                catalog1.ListMyOrder.Add(currentOrder);
                catalog1.orderBindingSource.ResetBindings(true);
                FileStream fs = new FileStream(@"DataBases\OrderDataBase.bin", FileMode.Create);
                bf.Serialize(fs, catalog1.ListOrder);
                fs.Close();
            }
            catalog1.Enabled = true;
        }

        private void dataGridViewOrder_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //При попытке ввода некорректных данных, будет показано сообщение об ошибке, а значение ячейки вернется к значению по умолчанию.
            MessageBox.Show("Введены некорректные данные. Попробуйте ещё раз.");
            dataGridViewOrder.CurrentCell.Value = dataGridViewOrder.CurrentCell.DefaultNewRowValue;
        }

        private void dataGridViewOrder_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //При каждом изменении значений ячеек в таблице пересчитывается сумма заказа
            textBoxOrderSum.Text = sum.ToString();
        }
    }
}

