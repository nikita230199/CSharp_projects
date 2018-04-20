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
    public partial class Admin : Form
    {
        List<Book> ListBook = new List<Book>();//Список книг
        List<User> ListUser = new List<User>();//Список пользователей
        List<Role> ListRole = new List<Role>();//Список ролей
        List<Order> ListOrder = new List<Order>();//Список заказов
        Start start1;//Объект начальной формы
        BinaryFormatter bf = new BinaryFormatter();//Объект для сериализации и десериализации

        public Admin()
        {
            InitializeComponent();
        }

        public Admin(Start s1)
        {
            InitializeComponent();
            start1 = s1;//Объект начальной формы инициализируется открытой невидимой формой
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            //Считываются книги
            if (File.Exists(@"DataBases\BookDataBase.bin"))
            {
                FileStream fs = new FileStream(@"DataBases\BookDataBase.bin", FileMode.Open);
                ListBook = (List<Book>)bf.Deserialize(fs);
                fs.Close();
            }

            //Считываются пользователи
            if (File.Exists(@"DataBases\UsersDataBase.bin"))
            {
                FileStream fsUserOpen = new FileStream(@"DataBases\UsersDataBase.bin", FileMode.Open);
                ListUser = (List<User>)bf.Deserialize(fsUserOpen);
                fsUserOpen.Close();
            }

            //Считываются роли
            if (File.Exists(@"DataBases\RolesDataBase.bin"))
            {
                FileStream fsRoleOpen = new FileStream(@"DataBases\RolesDataBase.bin", FileMode.Open);
                ListRole = (List<Role>)bf.Deserialize(fsRoleOpen);
                fsRoleOpen.Close();
            }

            //Считывается код администратора
            if (File.Exists(@"DataBases\EnrollCode.bin"))
            {
                FileStream fsRoleOpen = new FileStream(@"DataBases\EnrollCode.bin", FileMode.Open);
                textBoxAdminCode.Text = bf.Deserialize(fsRoleOpen).ToString();
                fsRoleOpen.Close();
            }

            //Считываются заказы
            if (File.Exists(@"DataBases\OrderDataBase.bin"))
            {
                FileStream fs = new FileStream(@"DataBases\OrderDataBase.bin", FileMode.Open);
                ListOrder = (List<Order>)bf.Deserialize(fs);
                fs.Close();
            }

            //Осуществляется привязка к данным
            bookBindingSource.DataSource = ListBook;
            userBindingSource.DataSource = ListUser;
            roleBindingSource.DataSource = ListRole;
            orderBindingSource.DataSource = ListOrder;

            //Осуществляется добавление списка с ролями возможными столбцами для поиска к элементу управления comboBoxSearch (поиск книг во вкладке книги)
            for (int i = 0; i < dataGridViewCatalog.Columns.Count; i++)
                comboBoxSearchBook.Items.Add(dataGridViewCatalog.Columns[i].HeaderText);

            //Осуществляется добавление списка с ролями возможными столбцами для поиска к элементу управления comboBoxSearchUser (поиск пользователей во вкладке пользователи)
            for (int i = 0; i < dataGridViewUsers.Columns.Count; i++)
                comboBoxSearchUser.Items.Add(dataGridViewUsers.Columns[i].HeaderText);

            //Осуществляется добавление списка с операциями сравнения к элементу управления comboBoxOperator (вкладка книги)
            string[] operators = new string[] { "=", ">", ">=", "<", "<=", "<>" };//Операторы сравнения для поиска 
            comboBoxOperator.Items.AddRange(operators);
            comboBoxOperator.Enabled = false;//По умолчанию свойство Enabled установлено false

            //Осуществляется добавление списка статусов заказа к столбцу статус
            orderStatus.DataSource = Order.statuses;

            password.Visible = checkBoxPassword.Checked;//Отображение пароля пользователя в вкладке Пользователи зависит от свойства checkBoxPassword.Checked
        }

        private void SerializeObject(object o, string path)
        {
            //Метод, который осуществляет сериализацию объекта в заданный файл
            FileStream fs = new FileStream(path, FileMode.Create);
            bf.Serialize(fs, o);
            fs.Close();
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Сохранить изменения?", "Сохранение изменений", MessageBoxButtons.YesNoCancel); //Спрашивается у пользователя, хочет ли он сохранить изменения
            if (result == DialogResult.Yes)//Если результат диалога Да, то происходит сохранние всех табиц
            {
                сохранитьВсеToolStripMenuItem_Click(sender, e);
                //Закрывается невидимая пользователю начальная форма
                start1.Close();
            }
            else if (result == DialogResult.No) { start1.Close(); } //Если результат диалога Нет, то ничего не происходит и форма закрывается, вместе с начальной формой
            else if (result == DialogResult.Cancel) { e.Cancel = true; }//Если результат диалога Отмена, тогда происходит отмена закрытия формы
        }

        private void dataGridViewCatalog_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //При попытке ввода некорректных данных, будет показано сообщение об ошибке, а значение ячейки вернется к значению по умолчанию.
            MessageBox.Show("Введены некорректные данные. Попробуйте ещё раз.");
            dataGridViewCatalog.CurrentCell.Value = dataGridViewCatalog.CurrentCell.DefaultNewRowValue;
        }

        private void dataGridViewUsers_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //При попытке ввода некорректных данных, будет показано сообщение об ошибке, а значение ячейки вернется к значению по умолчанию.
            MessageBox.Show("Введены некорректные данные. Попробуйте ещё раз.");
            dataGridViewUsers.CurrentCell.Value = dataGridViewUsers.CurrentCell.DefaultNewRowValue;
        }

        private void dataGridViewRoles_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //При попытке ввода некорректных данных, будет показано сообщение об ошибке, а значение ячейки вернется к значению по умолчанию.
            MessageBox.Show("Введены некорректные данные. Попробуйте ещё раз.");
            dataGridViewRoles.CurrentCell.Value = dataGridViewRoles.CurrentCell.DefaultNewRowValue;
        }

        private void dataGridViewOrders_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //При попытке ввода некорректных данных, будет показано сообщение об ошибке, а значение ячейки вернется к значению по умолчанию.
            MessageBox.Show("Введены некорректные данные. Попробуйте ещё раз.");
            dataGridViewOrders.CurrentCell.Value = dataGridViewOrders.CurrentCell.DefaultNewRowValue;
        }

        private void dataGridViewOrderedBooks_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //При попытке ввода некорректных данных, будет показано сообщение об ошибке, а значение ячейки вернется к значению по умолчанию.
            MessageBox.Show("Введены некорректные данные. Попробуйте ещё раз.");
            dataGridViewOrderedBooks.CurrentCell.Value = dataGridViewOrderedBooks.CurrentCell.DefaultNewRowValue;
        }

        private void buttonSaveBooks_Click(object sender, EventArgs e)
        {
            //Записываются в файл все книги
            SerializeObject(ListBook, @"DataBases\BookDataBase.bin");
        }

        private void buttonSaveUsers_Click(object sender, EventArgs e)
        {
            //Записываются в файл все пользователи
            SerializeObject(ListUser, @"DataBases\UsersDataBase.bin");
        }

        private void buttonSaveRoles_Click(object sender, EventArgs e)
        {
            //Записываются в файл все роли
            SerializeObject(ListRole, @"DataBases\RolesDataBase.bin");
        }

        private void buttonSaveAdminCode_Click(object sender, EventArgs e)
        {
            //Записывается в файл код администратора
            SerializeObject(textBoxAdminCode.Text, @"DataBases\EnrollCode.bin");
        }

        private void buttonSaveOrders_Click(object sender, EventArgs e)
        {
            //Записываются в файл все заказы
            SerializeObject(ListOrder, @"DataBases\OrderDataBase.bin");
        }

        private void сохранитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Происходит сохрание всех файлов: Книги, Пользователи, Роли, Код Администратора и Заказы
            buttonSaveBooks_Click(sender, e);
            buttonSaveUsers_Click(sender, e);
            buttonSaveRoles_Click(sender, e);
            buttonSaveAdminCode_Click(sender, e);
            buttonSaveOrders_Click(sender, e);
        }

        private void книги_открытьToolStripMenuItem_Click(object sender, EventArgs e)
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
                    MessageBox.Show("При чтении файла произошла ошибка. Возможно, что данные в файле были повреждены, или были введены некорректно. Перепроверьте вводимые данные","Ошибка чтения файла");
                }
        }

        private void книги_сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void пользователи_открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Считывание файла, выбранного пользователем и содержащего информацию о пользователях
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                try
                {
                    List<User> tempListUser = new List<User>();//Создается временный список, в который будут считываться элементы из файла
                    User u = new User();
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    while (true)
                    {
                        string firstString = sr.ReadLine();
                        if (firstString == null) break;//Если считываемая строка оказывается пустой, это означает конец файла, и цикл прекращается
                        string[] str = { firstString /*Логин*/,
                            sr.ReadLine() /*Пароль*/,
                            sr.ReadLine() /*Фамилия*/,
                            sr.ReadLine() /*Имя*/,
                            sr.ReadLine() /*Отчество*/,
                            sr.ReadLine() /*id роли*/,
                            sr.ReadLine() /*название роли*/};

                        /*Если в текущем списке ролей есть считываемая роль, то эта роль и будет присвоена считываемому пользователю.
                        А если не существует, то пользователю по умолчанию будет присвоена последняя роль в списке ListRole*/

                        bool f = false;//Логическая переменная, значение которой будет означать есть ли в текущем списке ролей есть считываемая роль
                        foreach (Role r in ListRole)
                            if (int.Parse(str[5]) == r.roleId && str[6] == r.roleName)//Если найдена считываемая роль в списке ролей, то создается новый пользователь c этой ролью
                            {
                                f = true;
                                u = new User(str[0], str[1], str[2], str[3], str[4], r);
                                break;
                            }

                        if (!f)//Если соответствующей роли в списке найдено не было, то пользователю по умолчанию будет присвоена последняя роль в списке ListRole
                            u = new User(str[0], str[1], str[2], str[3], str[4], ListRole[ListRole.Count - 1]);

                        tempListUser.Add(u);//Новый пользователь добавляется в список
                    }
                    sr.Close();

                    ListUser.Clear();
                    ListUser.AddRange(tempListUser);
                    userBindingSource.ResetBindings(true);//Происходит обновление источника данных
                }
                catch
                {
                    MessageBox.Show("При чтении файла произошла ошибка. Возможно, что данные в файле были повреждены, или были введены некорректно. Перепроверьте вводимые данные", "Ошибка чтения файла");
                }
        }

        private void пользователи_сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Происходит выгрузка списка Пользователей в выбранный пользователем файл
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                foreach (User u in ListUser)
                {
                    sw.WriteLine(u.login);
                    sw.WriteLine(u.password);
                    sw.WriteLine(u.userSurname);
                    sw.WriteLine(u.userFirstName);
                    sw.WriteLine(u.userMiddleName);
                    sw.WriteLine(u.userRole.roleId);
                    sw.WriteLine(u.userRole.roleName);
                }
                sw.Close();
            }
        }

        private void роли_открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Считывание файла, выбранного пользователем и содержащего информацию о ролях
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    List<Role> tempListRole = new List<Role>();//Создается временный список, в который будут считываться элементы из файла
                    Role r = new Role();
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    while (true)
                    {
                        string firstString = sr.ReadLine();
                        if (firstString == null) break;//Если считываемая строка оказывается пустой, это означает конец файла, и цикл прекращается
                        int i = int.Parse(firstString);
                        r = new Role(i, sr.ReadLine());
                        tempListRole.Add(r);
                    }
                    sr.Close();

                    ListRole.Clear();
                    ListRole.AddRange(tempListRole);
                    roleBindingSource.ResetBindings(true);//Происходит обновление источника данных
                }
                catch
                {
                    MessageBox.Show("При чтении файла произошла ошибка. Возможно, что данные в файле были повреждены, или были введены некорректно. Перепроверьте вводимые данные", "Ошибка чтения файла");
                }
            }
        }

        private void роли_сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Происходит выгрузка списка Ролей в выбранный пользователем файл
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                foreach (Role r in ListRole)
                {
                    sw.WriteLine(r.roleId);
                    sw.WriteLine(r.roleName);
                }
                sw.Close();
            }
        }

        private void заказы_открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Считывание файла, выбранного пользователем и содержащего информацию о заказах
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                try
                {
                    List<Order> tempListOrder = new List<Order>();//Создается временный список, в который будут считываться элементы из файла
                    Order o = new Order();
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    while (true)
                    {
                        string firstString = sr.ReadLine();
                        if (firstString == null) break;//Если считываемая строка оказывается пустой, это означает конец файла, и цикл прекращается

                        string[] strOrder = { firstString /*number*/,
                            sr.ReadLine() /*date*/,
                            sr.ReadLine() /*sum*/,
                            sr.ReadLine() /*userSurname*/,
                            sr.ReadLine() /*userFirstName*/,
                            sr.ReadLine() /*userMiddleName*/,
                            sr.ReadLine() /*phoneNumber*/,
                            sr.ReadLine() /*delivery*/,
                            sr.ReadLine() /*adress*/,
                            sr.ReadLine() /*orderStatusNum*/
                            };

                        User u = new User();
                        string[] strUser = { sr.ReadLine() /*Логин*/,
                            sr.ReadLine() /*Пароль*/,
                            sr.ReadLine() /*Фамилия*/,
                            sr.ReadLine() /*Имя*/,
                            sr.ReadLine() /*Отчество*/,
                            sr.ReadLine() /*id роли*/,
                            sr.ReadLine() /*название роли*/};

                        /*Если в текущем списке ролей есть считываемая роль, то эта роль и будет присвоена считываемому пользователю.
                        А если не существует, то пользователю по умолчанию будет присвоена последняя роль в списке ListRole*/

                        bool f = false;//Логическая переменная, значение которой будет означать есть ли в текущем списке ролей есть считываемая роль
                        foreach (Role r in ListRole)
                            if (int.Parse(strUser[5]) == r.roleId && strUser[6] == r.roleName)//Если найдена считываемая роль в списке ролей, то создается новый пользователь c этой ролью
                            {
                                f = true;
                                u = new User(strUser[0], strUser[1], strUser[2], strUser[3], strUser[4], r);
                                break;
                            }

                        if (!f)//Если соответствующей роли в списке найдено не было, то пользователю по умолчанию будет присвоена последняя роль в списке ListRole
                            u = new User(strUser[0], strUser[1], strUser[2], strUser[3], strUser[4], ListRole[ListRole.Count - 1]);

                        List<OrderedBook> tempListOrderedBook = new List<OrderedBook>();//Создается временный список, в который будут считываться элементы из файла

                        uint count = uint.Parse(sr.ReadLine());
                        for (int i = 0; i < count; i++)
                        {
                            Book b = new Book(sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), uint.Parse(sr.ReadLine()), uint.Parse(sr.ReadLine()), uint.Parse(sr.ReadLine()));
                            uint n = uint.Parse(sr.ReadLine());
                            b = FindBook(b);
                            tempListOrderedBook.Add(new OrderedBook(b, n));
                        }

                        o = new Order(strOrder[0], DateTime.Parse(strOrder[1]), tempListOrderedBook, u, strOrder[3], strOrder[4], strOrder[5], strOrder[6], bool.Parse(strOrder[7]), strOrder[8], int.Parse(strOrder[9]));
                        tempListOrder.Add(o);
                    }
                    sr.Close();

                    ListOrder.Clear();
                    ListOrder.AddRange(tempListOrder);
                    orderBindingSource.ResetBindings(true);//Происходит обновление источника данных
                }
                catch
                {
                    MessageBox.Show("При чтении файла произошла ошибка. Возможно, что данные в файле были повреждены, или были введены некорректно. Перепроверьте вводимые данные", "Ошибка чтения файла");
                }
        }

        private void заказы_сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Происходит выгрузка списка Заказов в выбранный пользователем файл
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                foreach (Order o in ListOrder)
                {
                    sw.WriteLine(o.number);
                    sw.WriteLine(o.date);
                    sw.WriteLine(o.sum);
                    sw.WriteLine(o.userSurname);
                    sw.WriteLine(o.userFirstName);
                    sw.WriteLine(o.userMiddleName);
                    sw.WriteLine(o.phoneNumber);
                    sw.WriteLine(o.delivery);
                    sw.WriteLine(o.adress);
                    sw.WriteLine(o.orderStatusNum);

                    User u = o.user;
                    sw.WriteLine(u.login);
                    sw.WriteLine(u.password);
                    sw.WriteLine(u.userSurname);
                    sw.WriteLine(u.userFirstName);
                    sw.WriteLine(u.userMiddleName);
                    sw.WriteLine(u.userRole.roleId);
                    sw.WriteLine(u.userRole.roleName);

                    sw.WriteLine(o.orderedBooks.Count());
                    for (int i = 0; i < o.orderedBooks.Count(); i++)
                    {
                        Book b = o.orderedBooks[i].book;
                        sw.WriteLine(b.isbn);
                        sw.WriteLine(b.name);
                        sw.WriteLine(b.authorName);
                        sw.WriteLine(b.price);
                        sw.WriteLine(b.storehouse);
                        sw.WriteLine(b.shop);
                        sw.WriteLine(o.orderedBooks[i].number);
                    }
                }
                sw.Close();
            }
        }

        private Book FindBook(Book book)
        {
            bool f = false;
            int i;
            for (i = 0; i < ListBook.Count; i++)
                if (book.isbn == ListBook[i].isbn)
                {
                    f = true;
                    break;
                }
            if (f) return ListBook[i];
            else return book;
        }

        private void о_программеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Происходит при нажатии элемента управления 'О программе'
                string[] readText = File.ReadAllLines(@"Manual\about.txt");//Загружается файл, содаржащий сведения о программе
                string str = "";
                foreach (string s in readText)
                    str += s + "\n";
                MessageBox.Show(str, "О программе");//Информация о программе выводится пользователю в диалоговом окне
            }
            catch
            {
                //Если файла не существует, то выводится сообщение об ошибке
                MessageBox.Show("Информация находится в разработке", "О программе");
            }
        }

        private void просмотр_справкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Происходит при нажатии элемента управления 'Справка'
                Process processNotebook = new Process();
                processNotebook.StartInfo.FileName = @"Manual\HelpAdmin.txt";//Файл, содержащий справку, открывается в блокноте
                processNotebook.StartInfo.Arguments = "";
                processNotebook.Start();
            }
            catch
            {
                //Если файла не существует, то выводится сообщение об ошибке
                MessageBox.Show("Справка находится в разработке", "Справка");
            }
        }

        private void путь_к_программеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Выводит в диалоговом окне информацию о пути к программе, а также файлах и вложенных папках текущего каталога
            string path = Application.StartupPath;
            DirectoryInfo dir = new DirectoryInfo(path);
            List<string> files = new List<string>();
            List<string> directories = new List<string>();
            string message = "Путь к программе: " + path + "\n";
            message += "\n" + "Содержимое: " + "\n";
            foreach (DirectoryInfo dri in dir.GetDirectories())
            {
                directories.Add(dri.Name);
                message += dri.Name + "\n";
            }
            foreach (var f in dir.GetFiles())
            {
                files.Add(f.Name);
                message += f.Name + "\n";
            }
            MessageBox.Show(message, "Путь к программе");
        }

        private void buttonSearchBook_Click(object sender, EventArgs e)
        {
            dataGridViewCatalog.CurrentCell = null;//Необходимо сделать во избежании ошибки: если придется сделать свойство Visible = false, в выделенной ячейке
            int a;//Переменная, которая будет обозначать выбранный пользователем столбец из comboBoxSearchBook, по которому будет осуществляться поиск

            if (comboBoxSearchBook.SelectedItem == null)//Если не выбран столбец по которому будет осуществляться поиск, то после вывода сообщения об ошибке, будет произведен принудительный выход из метода
            {
                MessageBox.Show("Для осуществления поиска необходимо выбрать столбец, по которому будет проводиться поиск. \nЕго можно выбрать в ниспадающем списке над кнопкой 'Найти'", "Ошибка поиска");//Выдается сообщение об ошибке ввода
                return;//Прекращается работа метода
            }
            else
                a = comboBoxSearchBook.SelectedIndex;//Так как мы добавляли в comboBoxSearchBook заголовки всех столбцов последовательно, то выбранный индекс совпадает с индексом нужного стобца в dataGridViewCatalog

            if (a > 2)//В столбцах c индексом больше 2 сержатся числовые данные, для которых необходим поиск с использованием операторов сравнения
            {
                int b = comboBoxOperator.SelectedIndex;//Получение индекса выбранного оператора сравнения

                for (int i = 0; i < dataGridViewCatalog.Rows.Count - 1; i++)//Для каждой строки в цикле проверяется соответствие условию
                {
                    uint s = (uint)dataGridViewCatalog[a, i].Value;//Значение нужной ячейки (с чем будем сравнивать)
                    bool f = false;//Логическая переменная показывающая успешность или не успешность сравнения - подходит или нет. По умолчанию стоит значение false
                    int t;//Переменная в которую запишется значение textBoxSearchBook (условие поиска введенное пользователем)

                    if (int.TryParse(textBoxSearchBook.Text, out t))//Происходит проверка успешности преобразования введенных пользователем данных в тип int
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
                                    if (s > t) f = true;
                                    break;
                                }
                            case 2:
                                {
                                    if (s >= t) f = true;
                                    break;
                                }
                            case 3:
                                {
                                    if (s < t) f = true;
                                    break;
                                }
                            case 4:
                                {
                                    if (s <= t) f = true;
                                    break;
                                }
                            case 5:
                                {
                                    if (s != t) f = true;
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
                        textBoxSearchBook.Text = "";//Значение строки поиска обнуляется
                        break;//Происходит выход из цикла
                    }

                    if (f) dataGridViewCatalog.Rows[i].Visible = true;//Если переменная показывает что сравнение прошло успешно (f = true) свойство строки Visible устанавливается в значение true
                    else dataGridViewCatalog.Rows[i].Visible = false;//Иначе - в значение false
                }
            }
            else //Столбцы с индексами меньше трех содержат текстовые данные, поэтому происходит поиск по части строки
                for (int i = 0; i < dataGridViewCatalog.Rows.Count - 1; i++)//Для каждой строки в цикле проверяется соответствие условию
                {
                    string s = dataGridViewCatalog[a, i].Value.ToString();//Значение нужной ячейки (с чем будем сравнивать)
                    if (s.Contains(textBoxSearchBook.Text)) dataGridViewCatalog.Rows[i].Visible = true;//Если ячейка содержит введенную пользователем строку, то свойство строки Visible устанавливается в значение true
                    else dataGridViewCatalog.Rows[i].Visible = false;//Иначе - в значение false
                }
        }

        private void buttonDisplayAllBooks_Click(object sender, EventArgs e)
        {
            //При нажатии этой кнопки, свойство Visible всех строк будет установлено в значение true (все строки станут видимыми)
            for (int i = 0; i < dataGridViewCatalog.Rows.Count - 1; i++)
                dataGridViewCatalog.Rows[i].Visible = true;

            //Элементам управления, необходимых для поиска, присваивается значение по умолчанию
            textBoxSearchBook.ResetText();
            comboBoxSearchBook.ResetText();
            comboBoxOperator.ResetText();
        }

        private void comboBoxSearchBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Поиск по таблице с книгами
            //Происходит при каждом изменении выбора столбца, по которому будет осуществляться поиск
            int a = comboBoxSearchBook.SelectedIndex;//Так как мы добавляли в comboBoxSearch заголовки всех столбцов последовательно, то выбранный индекс совпадает с индексом нужного стобца в dataGridViewCatalog
            if (a <= 2) comboBoxOperator.Enabled = false;//В столбцах 0-2 у нас содержатся строковые данные, для которых использование операторов сравнения не предусмотрено. Поэтому comboBoxOperator будет недоступен пользователю
            else comboBoxOperator.Enabled = true;//В столбцах 3-5 содержатся числовые данные, для которых использование операторов сравнения предусмотрено. Поэтому comboBoxOperator будет доступен пользователю
        }

        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            /*Отображение пароля пользователя в вкладке Пользователи зависит от свойства checkBoxPassword.Checked.
             Поэтому, при каждом изменении свойства Checked, происходит изменение свойства Visible столбца с паролями.
             И если Checked=true (отмечены), то и passwordVisible будет равно true (столбец виден).*/
            password.Visible = checkBoxPassword.Checked;
        }

        private void buttonSearchUser_Click(object sender, EventArgs e)
        {
            dataGridViewUsers.CurrentCell = null;//Необходимо сделать во избежании ошибки: если придется сделать свойство Visible = false, в выделенной ячейке
            int a;//Переменная, которая будет обозначать выбранный пользователем столбец из comboBoxSearchUser, по которому будет осуществляться поиск

            if (comboBoxSearchUser.SelectedItem == null)//Если не выбран столбец по которому будет осуществляться поиск, то после вывода сообщения об ошибке, будет произведен принудительный выход из метода
            {
                MessageBox.Show("Для осуществления поиска необходимо выбрать столбец, по которому будет проводиться поиск. \nЕго можно выбрать в ниспадающем списке над кнопкой 'Найти'", "Ошибка поиска");//Выдается сообщение об ошибке ввода
                return;//Прекращается работа метода
            }
            else
                a = comboBoxSearchUser.SelectedIndex;//Так как мы добавляли в comboBoxSearchUser заголовки всех столбцов последовательно, то выбранный индекс совпадает с индексом нужного стобца в dataGridViewUsers

            //Для каждой строки в таблице происходит поиск по части строки
            for (int i = 0; i < dataGridViewUsers.Rows.Count - 1; i++)
            {
                string s = dataGridViewUsers[a, i].Value.ToString();//Значение нужной ячейки (с чем будем сравнивать)
                if (s.Contains(textBoxSearchUser.Text)) dataGridViewUsers.Rows[i].Visible = true;//Если ячейка содержит введенную пользователем строку, то свойство строки Visible устанавливается в значение true
                else dataGridViewUsers.Rows[i].Visible = false;//Иначе - в значение false
            }
        }

        private void buttonDisplayAllUsers_Click(object sender, EventArgs e)
        {
            //При нажатии этой кнопки, свойство Visible всех строк будет установлено в значение true (все строки станут видимыми)
            for (int i = 0; i < dataGridViewUsers.Rows.Count - 1; i++)
                dataGridViewUsers.Rows[i].Visible = true;

            //Элементам управления, необходимых для поиска, присваивается значение по умолчанию
            textBoxSearchUser.ResetText();
            comboBoxSearchUser.ResetText();
        }

        private void dataGridViewRoles_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            //При попытке удаления пользователем роли, будет выведено предупреждение
            DialogResult result = MessageBox.Show("Вы уверены? При удалениии роли все связанные с ней пользователи будут тоже удалены.", "Удаление роли", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                //Происходит удаление всех пользователей с этой ролью
                int d = e.Row.Index;//Индекс удаляемого элемента
                List<int> delete = new List<int>();//В данный массив будут вноситься индексы пользователей, помеченных на удаление
                for (int i = 0; i < ListUser.Count; i++)
                    if (ListUser[i].userRole.roleName == ListRole[d].roleName)
                        delete.Add(i);//Если роли совпадают, то индекс пользователя заносится в массив на удаление

                for (int i = delete.Count - 1; i >= 0; i--)
                    dataGridViewUsers.Rows.RemoveAt(delete[i]);//Удаляются все пользователи, чьи индексы были в массиве на удаление
            }
            else e.Cancel = true;//Иначе, удаление отменяется
        }

        private void buttonSearchOrders_Click(object sender, EventArgs e)
        {
            dataGridViewOrders.CurrentCell = null;
            for (int i = 0; i < dataGridViewOrders.Rows.Count; i++)//Для каждой строки в цикле проверяется соответствие условию
            {
                if (ListOrder[i].date.Date == dateTimePicker1.Value.Date)
                    dataGridViewOrders.Rows[i].Visible = true;//Если ячейка совпадает с введенной датой, то свойство строки Visible устанавливается в значение true
                else dataGridViewOrders.Rows[i].Visible = false;//Иначе - в значение false
            }
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

        private void buttonDisplayAllOrders_Click(object sender, EventArgs e)
        {
            //При нажатии этой кнопки, свойство Visible всех строк будет установлено в значение true (все строки станут видимыми)
            for (int i = 0; i < dataGridViewOrders.Rows.Count; i++)
                dataGridViewOrders.Rows[i].Visible = true;
            checkBoxDisplay.Checked = false;
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

        private void dataGridViewOrders_CurrentCellChanged(object sender, EventArgs e)
        {
            //Если имеется возможность (то есть строки пока не пусты), то надписи над таблицей с книгами текущего заказа присваивается номер текущего заказа
            try
            {
                labelOrderedBooks.Text = "Заказ №: " + dataGridViewOrders.CurrentRow.Cells[0].Value.ToString();
            }
            catch { }
        }
    }
}


