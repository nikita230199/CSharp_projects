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
using System.Diagnostics;



namespace ИС_Книжный_магазин
{
    public partial class Catalog : Form
    {
        public List<Book> ListBook; //Список книг
        public List<Order> ListOrder = new List<Order>();//Список заказов
        public List<Order> ListMyOrder = new List<Order>();//Список заказов текущего пользователя
        public Start start1;//Объект начальной формы
        BinaryFormatter bf = new BinaryFormatter();//Объект для сериализации/десериализации

        public Catalog()
        {
            InitializeComponent();
        }

        public Catalog(Start s1)
        {
            InitializeComponent();
            start1 = s1; //Объект начальной формы инициализируется открытой невидимой формой
            labelCurrentUser.Text = start1.currentUser.login;//Теперь сверху формы отображается логин пользователя
        }

        private void Catalog_Load(object sender, EventArgs e)
        {
            //Считываются книги
            if (File.Exists(@"DataBases\BookDataBase.bin"))
            {
                FileStream fs = new FileStream(@"DataBases\BookDataBase.bin", FileMode.Open);
                ListBook = (List<Book>)bf.Deserialize(fs);
                fs.Close();
            }

            //Считываются заказы
            if (File.Exists(@"DataBases\OrderDataBase.bin"))
            {
                FileStream fs = new FileStream(@"DataBases\OrderDataBase.bin", FileMode.Open);
                ListOrder = (List<Order>)bf.Deserialize(fs);
                fs.Close();
            }

            //Отбираются заказы, которые принадлежат данному пользователю
            foreach (Order o in ListOrder)
                if (o.user.login == start1.currentUser.login)
                    ListMyOrder.Add(o);

            //Осуществляется привязка к данным
            bookBindingSource.DataSource = ListBook;
            orderBindingSource.DataSource = ListMyOrder;
            
            //Осуществляется добавление списка с ролями возможными столбцами для поиска к элементу управления comboBoxSearch
            for (int i = 0; i < dataGridViewCatalog.Columns.Count; i++)
                comboBoxSearch.Items.Add(dataGridViewCatalog.Columns[i].HeaderText);

            //Осуществляется добавление списка с операциями сравнения к элементу управления comboBoxOperator
            string[] operators = new string[] { "=", ">", "<" };//Операторы сравнения для поиска 
            comboBoxOperator.Items.AddRange(operators);
            comboBoxOperator.Enabled = false;//По умолчанию свойство Enabled установлено false
        }

        private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Происходит при каждом изменении выбора столбца, по которому будет осуществляться поиск
            int a = comboBoxSearch.SelectedIndex;//Так как мы добавляли в comboBoxSearch заголовки всех столбцов последовательно, то выбранный индекс совпадает с индексом нужного стобца в dataGridViewCatalog
            if (a < 3) comboBoxOperator.Enabled = false;//В столбцах 0-2 у нас содержатся строковые данные, для которых использование операторов сравнения не предусмотрено. Поэтому comboBoxOperator будет недоступен пользователю
            else comboBoxOperator.Enabled = true;//В столбцах 3-4 содержатся числовые данные, для которых использование операторов сравнения предусмотрено. Поэтому comboBoxOperator будет доступен пользователю
        }

        private void buttonSearchBook_Click(object sender, EventArgs e)
        {
            dataGridViewCatalog.CurrentCell = null;//Необходимо сделать во избежании ошибки: если придется сделать свойство Visible = false, в выделенной ячейке

            int a;//Переменная, которая будет обозначать выбранный пользователем столбец из comboBoxSearch, по которому будет осуществляться поиск
            if (comboBoxSearch.SelectedItem == null)//Если не выбран столбец по которому будет осуществляться поиск, то после вывода сообщения об ошибке, будет произведен принудительный выход из метода
            {
                MessageBox.Show("Для осуществления поиска необходимо выбрать столбец, по которому будет проводиться поиск. \nЕго можно выбрать в ниспадающем списке над кнопкой 'Найти'", "Ошибка поиска");//Выдается сообщение об ошибке ввода
                return;//Прекращается работа метода
            }

            else
                a = comboBoxSearch.SelectedIndex;//Так как мы добавляли в comboBoxSearch заголовки всех столбцов последовательно, то выбранный индекс совпадает с индексом нужного стобца в dataGridViewCatalog

            if (a > 2)//В столбцах c индексом больше 2 сержатся числовые данные, для которых необходим поиск с использованием операторов сравнения
            {
                int b = comboBoxOperator.SelectedIndex;//Получение индекса выбранного оператора сравнения

                for (int i = 0; i < dataGridViewCatalog.Rows.Count; i++)//Для каждой строки в цикле проверяется соответствие условию
                {
                    uint s = (uint)dataGridViewCatalog[a, i].Value;//Значение нужной ячейки (с чем будем сравнивать)
                    bool f = false;//Логическая переменная показывающая успешность или не успешность сравнения - подходит или нет. По умолчанию стоит значение false
                    int t;//Переменная в которую запишется значение textBoxFilter (условие поиска введенное пользователем)

                    if (int.TryParse(textBoxFilter.Text, out t))//Происходит проверка успешности преобразования введенных пользователем данных в тип int
                        switch (b)
                        /*По индексу выбранного оператора сравнения происходит выбор соответствующего оператору действия. 
                         * В каждом варианте case выполняется соответствующее сравнение значения столбца и введенного пользователем значения, 
                         * и если оно успешно, то логической переменной f (отвечающей за успешность сравнения) присваивается значеиние true*/
                        {
                            case 0:
                                {
                                    if (s == t) f = true;
                                    break;
                                }
                            case 1:
                                {
                                    /*Несмотря на то, что оператор содержит значение строгого неравенства, поиск будет осуществляться таким образом. 
                                     * Это сделано с целью того, чтобы покупатель увидел больше книг, которые могли бы ему подойти*/
                                    if (s >= t) f = true;
                                    break;
                                }
                            case 2:
                                {
                                    if (s <= t) f = true;
                                    break;
                                }
                            default://Если оператор сравнения не выбран, то по умолчанию происходит проверка равенства
                                {
                                    if (s == t) f = true;
                                    break;
                                }
                        }
                    else //Происходит если введенная пользователем строка поиска не являлась числом (int.TryParse(textBoxFilter.Text, out t) вернуло значение false)
                    {
                        MessageBox.Show("Для поиска по выбранному столбцу необходимо ввести числовое значение в строку поиска", "Ошибка поиска");//Выдается сообщение об ошибке ввода
                        textBoxFilter.Text = "";//Значение строки поиска обнуляется
                        break;//Происходит выход из цикла
                    }

                    if (f) dataGridViewCatalog.Rows[i].Visible = true;//Если переменная показывает что сравнение прошло успешно (f = true) свойство строки Visible устанавливается в значение true
                    else dataGridViewCatalog.Rows[i].Visible = false;//Иначе - в значение false
                }
            }
            else //Столбцы с индексами меньше трех содержат текстовые данные, поэтому происходит поиск по части строки
                for (int i = 0; i < dataGridViewCatalog.Rows.Count; i++)
                {
                    string s = dataGridViewCatalog[a, i].Value.ToString();//Значение нужной ячейки (с чем будем сравнивать)
                    if (s.Contains(textBoxFilter.Text)) dataGridViewCatalog.Rows[i].Visible = true;//Если ячейка содержит введенную пользователем строку, то свойство строки Visible устанавливается в значение true
                    else dataGridViewCatalog.Rows[i].Visible = false;//Иначе - в значение false
                }
        }

        private void buttonDisplayAllBooks_Click(object sender, EventArgs e)
        {
            //При нажатии этой кнопки, свойство Visible всех строк будет установлено в значение true (все строки станут видимыми)
            for (int i = 0; i < dataGridViewCatalog.Rows.Count - 1; i++)
                dataGridViewCatalog.Rows[i].Visible = true;

            //Элементам управления, необходимых для поиска, присваивается значение по умолчанию
            textBoxFilter.ResetText();
            comboBoxSearch.ResetText();
            comboBoxOperator.ResetText();
        }

        private void Catalog_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Сохранить изменения?", "Сохранение изменений", MessageBoxButtons.YesNoCancel); //Спрашивается у пользователя, хочет ли он сохранить изменения
            if (result == DialogResult.Yes)//Если результат диалога Да, то происходит сохранние всех табиц
            {
                buttonSaveOrders_Click(sender, e);
                //Закрывается невидимая пользователю начальная форма
                start1.Close();
            }
            else if (result == DialogResult.No) { start1.Close(); } //Если результат диалога Нет, то ничего не происходит и форма закрывается, вместе с начальной формой
            else if (result == DialogResult.Cancel) { e.Cancel = true; }//Если результат диалога Отмена, тогда происходит отмена закрытия формы
        }

        private void просмотр_справкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Происходит при нажатии элемента управления 'Справка'
                Process processNotebook = new Process();
                processNotebook.StartInfo.FileName = @"Manual\HelpCatalog.txt";//Файл, содержащий справку, открывается в блокноте
                processNotebook.StartInfo.Arguments = "";
                processNotebook.Start();
            }
            catch
            {
                //Если файла не существует, то выводится сообщение об ошибке
                MessageBox.Show("Справка находится в разработке", "Справка");
            }
        }

        private void о_программеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Загружается файл, содержащий сведения о программе
                string[] readText = File.ReadAllLines(@"Manual\about.txt");
                string str = "";
                foreach (string s in readText)
                    str += s + "\n";
                MessageBox.Show(str, "О программе", MessageBoxButtons.OK);//Информация о программе выводится пользователю в диалоговом окне
            }
            catch
            {
                //Если файла не существует, то выводится сообщение об ошибке
                MessageBox.Show("Информация находится в разработке", "О программе");
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Считывание файла, выбранного пользователем и содержащего информацию о книгах
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                try
                {
                    List<Book> tempListBook = new List<Book>();//Создается временный список, в который будут считываться элементы из файла
                    Book b = new Book();
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    while (true)
                    {
                        string firstString = sr.ReadLine();
                        if (firstString == null) break;//Если считываемая строка оказывается пустой, это означает конец файла, и цикл прекращается
                        b = new Book(firstString, sr.ReadLine(), sr.ReadLine(), uint.Parse(sr.ReadLine()), uint.Parse(sr.ReadLine()), uint.Parse(sr.ReadLine()));
                        tempListBook.Add(b);
                    }
                    sr.Close();

                    ListBook.Clear();
                    ListBook.AddRange(tempListBook);
                    bookBindingSource.ResetBindings(true);//Происходит обновление источника данных
                }
                catch
                {
                    MessageBox.Show("При чтении файла произошла ошибка. Возможно, что данные в файле были повреждены, или были введены некорректно. Перепроверьте вводимые данные", "Ошибка чтения файла");
                }
        }

        private void сохранить_какToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Происходит выгрузка списка Книг в выбранный пользователем файл
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                foreach (Book b in ListBook)
                {
                    sw.WriteLine(b.isbn);
                    sw.WriteLine(b.name);
                    sw.WriteLine(b.authorName);
                    sw.WriteLine(b.price);
                    sw.WriteLine(b.storehouse);
                    sw.WriteLine(b.shop);
                }
                sw.Close();
            }
        }

        private void labelInvalidSearch_Click(object sender, EventArgs e)
        {
            //Событие происходит при нажатии на надпись 'Не нашли то, что искали?', и показывает в диалоговом окне справку по поиску
            string[] readText = File.ReadAllLines(@"Manual\Search.txt");
            string str = "";
            foreach (string s in readText)
                str += s + "\n";
            MessageBox.Show(str, "Справка: поиск", MessageBoxButtons.OK);
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            //Нажав на эту кнопку, можно произвести заказ книг
            FormOrder o = new FormOrder(this);
            o.Show();
            this.Enabled = false;
        }

        private void checkBoxNumber_CheckedChanged(object sender, EventArgs e)
        {
            //Если элемент checked, то и соответствующий столбец таблицы заказов будет visible, и наоборот
            numberOrder.Visible = checkBoxNumber.Checked;
        }

        private void checkBoxDate_CheckedChanged(object sender, EventArgs e)
        {
            //Если элемент checked, то и соответствующий столбец таблицы заказов будет visible, и наоборот
            date.Visible = checkBoxDate.Checked;
        }

        private void checkBoxSum_CheckedChanged(object sender, EventArgs e)
        {
            //Если элемент checked, то и соответствующий столбец таблицы заказов будет visible, и наоборот
            sum.Visible = checkBoxSum.Checked;
        }

        private void checkBoxSurname_CheckedChanged(object sender, EventArgs e)
        {
            //Если элемент checked, то и соответствующий столбец таблицы заказов будет visible, и наоборот
            userSurnameOrders.Visible = checkBoxSurname.Checked;
        }

        private void checkBoxFirstName_CheckedChanged(object sender, EventArgs e)
        {
            //Если элемент checked, то и соответствующий столбец таблицы заказов будет visible, и наоборот
            userFirstNameOrders.Visible = checkBoxFirstName.Checked;
        }

        private void checkBoxMiddleName_CheckedChanged(object sender, EventArgs e)
        {
            //Если элемент checked, то и соответствующий столбец таблицы заказов будет visible, и наоборот
            userMiddleNameOrders.Visible = checkBoxMiddleName.Checked;
        }

        private void checkBoxPhone_CheckedChanged(object sender, EventArgs e)
        {
            //Если элемент checked, то и соответствующий столбец таблицы заказов будет visible, и наоборот
            phoneNumber.Visible = checkBoxPhone.Checked;
        }

        private void checkBoxDelivery_CheckedChanged(object sender, EventArgs e)
        {
            //Если элемент checked, то и соответствующий столбец таблицы заказов будет visible, и наоборот
            delivery.Visible = checkBoxDelivery.Checked;
        }

        private void checkBoxAdress_CheckedChanged(object sender, EventArgs e)
        {
            //Если элемент checked, то и соответствующий столбец таблицы заказов будет visible, и наоборот
            adress.Visible = checkBoxAdress.Checked;
        }

        private void checkBoxStatus_CheckedChanged(object sender, EventArgs e)
        {
            //Если элемент checked, то и соответствующий столбец таблицы заказов будет visible, и наоборот
            orderStatus.Visible = checkBoxStatus.Checked;
        }

        private void buttonSaveOrders_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"DataBases\OrderDataBase.bin", FileMode.Create);
            bf.Serialize(fs, ListOrder);
            fs.Close();
        }

        private void buttonDisplayAllOrders_Click(object sender, EventArgs e)
        {
            //При нажатии этой кнопки, свойство Visible всех строк будет установлено в значение true (все строки станут видимыми)
            for (int i = 0; i < dataGridViewOrders.Rows.Count; i++)
                dataGridViewOrders.Rows[i].Visible = true;
            checkBoxDisplay.Checked = false;
        }

        private void checkBoxDisplay_CheckedChanged(object sender, EventArgs e)
        {
            //Если данный элемент Checked, то будут видны только те заказы, статус которых не равен "Заказ закрыт", то есть только открытые заказы
            dataGridViewOrders.CurrentCell = null;
            if (checkBoxDisplay.Checked)
                for (int i = 0; i < dataGridViewOrders.Rows.Count; i++)
                {
                    if (dataGridViewOrders["orderStatus", i].Value.ToString() == "Заказ закрыт")
                        dataGridViewOrders.Rows[i].Visible = false;
                    else dataGridViewOrders.Rows[i].Visible = true;
                }
            else buttonDisplayAllOrders_Click(sender, e);
        }

        private void buttonSearchOrders_Click(object sender, EventArgs e)
        {
            //Происходит поиск заказов по дате.
            dataGridViewOrders.CurrentCell = null;
            for (int i = 0; i < dataGridViewOrders.Rows.Count; i++)//Для каждой строки в цикле проверяется соответствие условию
            {
                if (ListMyOrder[i].date.Date == dateTimePicker1.Value.Date)
                    dataGridViewOrders.Rows[i].Visible = true;//Если ячейка совпадает с введенной датой, то свойство строки Visible устанавливается в значение true
                else dataGridViewOrders.Rows[i].Visible = false;//Иначе - в значение falseэ
            }
        }

        private void dataGridViewOrderedBooks_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //При попытке ввода некорректных данных, будет показано сообщение об ошибке, а значение ячейки вернется к значению по умолчанию.
            MessageBox.Show("Введены некорректные данные. Попробуйте ещё раз.");
            dataGridViewOrderedBooks.CurrentCell.Value = dataGridViewOrderedBooks.CurrentCell.DefaultNewRowValue;
        }

        private void dataGridViewOrders_CurrentCellChanged(object sender, EventArgs e)
        {
            //Если имеется возможность (то есть строки пока не пусты), то надписи над таблицей с книгами текущего заказа присваивается номер текущего заказа
            try
            {
                labelOrderedBooks.Text = "Заказ №: " + dataGridViewOrders.CurrentRow.Cells[0].Value.ToString();
            }
            catch { }
        }

        private void dataGridViewOrders_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            //При удалении заказа из списка 'мои заказы', он удаляется и из основного списка заказов
            ListOrder.Remove(ListMyOrder[e.Row.Index]);        
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
