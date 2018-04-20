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
    public partial class Start : Form
    {
        public static List<User> ListUser = new List<User>(); //Список пользователей
        public User currentUser; //Текущий пользователь
        uint countTry = 3; //Количество попыток ввода неверных логина и пароля

        public Start()
        {
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            //Если не существуют, создаются внутренние папки для документов
            DirectoryInfo DataBases = new DirectoryInfo("DataBases");
            if (!DataBases.Exists)
                DataBases.Create();
            DirectoryInfo Manual = new DirectoryInfo("Manual");
            if (!Manual.Exists)
                Manual.Create();

            //Считываются пользователи
            BinaryFormatter bf = new BinaryFormatter();//Объект для сериализации и десериализации
            if (File.Exists(@"DataBases\UsersDataBase.bin"))
            {
                FileStream fsUserOpen = new FileStream(@"DataBases\UsersDataBase.bin", FileMode.Open);
                ListUser = (List<User>)bf.Deserialize(fsUserOpen);
                fsUserOpen.Close();
            }
        }

        private void buttonEnroll_Click(object sender, EventArgs e)
        {
            //Запускается форма для регистрации
            Enroll enroll1 = new Enroll();
            enroll1.ShowDialog();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text; //Считываем введенный логин
            string password = textBoxPassword.Text; //Считываем введенный пароль
            bool f = false; //Логическая переменная, показывающая, корректно ли были введены логин и пароль

            foreach (User u in ListUser)
            {
                if (u.login == login && u.password == password) //Поиск соответствия введенных логина и пароля пользователям в списке
                {
                    f = true; //Проверка логина и пароля прошла успешно
                    currentUser = u; //Задается текущий пользователь
                    GoForvard(currentUser); //Вызывается метод, определяющий форму, которую нужно открыть текущему пользователю
                    break; //Выход из цикла
                }
            }
            if (!f)//Происходит если был проверен весь список прользователей, и не было найдено совпадения
            {
                countTry--;//Количество оставшихся попыток уменьшается
                MessageBox.Show("Неверные логин или пароль, пропробуйте ещё раз.\nПопыток осталось: " + countTry);
                if (countTry == 0)//Если осталось ноль попыток, то форма входа (Start) автоматически закрывается
                    Close();
            }
        }

        private void GoForvard(User u)//Метод, определяющий форму, которую нужно открыть текущему пользователю
        {
            Visible = false;//Форма входа (Start) делается не видимой пользователю
            switch (u.userRole.roleId)//При помощи индекса пользователя определяется форма, которую необходимо для него открыть
            {
                case 0:
                    {
                        Admin a = new Admin(this);//Открывается форма Администратора
                        a.Show();
                        break;
                    }
                case 1:
                    {
                        Catalog c = new Catalog(this);//Открывается форма Пользователя (Каталог)
                        c.Show();
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Для данного пользователя не определены дальнейшие действия. Свяжитесь с администратором.");
                        Close();
                        break;
                    }
            }
        }

        private void Start_FormClosing(object sender, FormClosingEventArgs e)
        {
            //При закрытии формы Start (то есть при завершении работы с приложением) выполняется резервное копирование файлов на диск D в папку BackUp
            //Если папка не существует, создается папка для резервных копий
            //Если по каким-то причинам создать папку не удается, то она создается в папке приложения
            DirectoryInfo backUp = new DirectoryInfo(@"D:\BackUp");
            if (!backUp.Exists)
                try
                {
                    backUp.Create();
                }
                catch
                {
                    backUp = new DirectoryInfo(@"BackUp");
                    backUp.Create();
                }
                

            FileInfo sourceFileUsers = new FileInfo(@"DataBases\UsersDataBase.bin");
            string destUsers = backUp.FullName +"/UsersDataBase.bin";
            sourceFileUsers.CopyTo(destUsers, true);

            FileInfo sourceFileRoles = new FileInfo(@"DataBases\RolesDataBase.bin");
            string destRoles = backUp.FullName + "/RolesDataBase.bin";
            sourceFileRoles.CopyTo(destRoles, true);

            FileInfo sourceFileBooks = new FileInfo(@"DataBases\BookDataBase.bin");
            string destBooks = backUp.FullName + "/BookDataBase.bin";
            sourceFileBooks.CopyTo(destBooks, true);

            FileInfo sourceFileAdminCode = new FileInfo(@"DataBases\EnrollCode.bin");
            string destAdminCode = backUp.FullName + "/EnrollCode.bin";
            sourceFileAdminCode.CopyTo(destAdminCode, true);

            FileInfo sourceFileOrders = new FileInfo(@"DataBases\OrderDataBase.bin");
            string destOrderse = backUp.FullName + "/OrderDataBase.bin";
            sourceFileAdminCode.CopyTo(destOrderse, true);
        }
    }
}