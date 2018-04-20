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
    public partial class Enroll : Form
    {
        List<Role> ListRole = new List<Role>();//Список ролей
        string enrollCode; //Код администратора, необходимый для регистрации новых администраторов 

        public Enroll()
        {
            InitializeComponent();
        }

        private void Enroll_Load(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();

            //Считываются роли
            if (File.Exists("DataBases/RolesDataBase.bin"))
            {
                FileStream fsRoleOpen = new FileStream("DataBases/RolesDataBase.bin", FileMode.Open);
                ListRole = (List<Role>)bf.Deserialize(fsRoleOpen);
                fsRoleOpen.Close();
            }
            else //По умолчанию задаются две роли: Администратор и Покупатель
            {
                ListRole.Add(new Role(0, "Администратор"));
                ListRole.Add(new Role(1, "Покупатель"));
            }

            //Считывается код администратора
            if (File.Exists("DataBases/EnrollCode.bin"))
            {
                FileStream fsRoleOpen = new FileStream("DataBases/EnrollCode.bin", FileMode.Open);
                enrollCode = bf.Deserialize(fsRoleOpen).ToString();
                fsRoleOpen.Close();
            }
            else enrollCode = DateTime.Today.Year.ToString(); //По умолчанию, код администратора равен текущему году

            buttonEnrollUser.Enabled = checkBoxPersonalData.Checked;//Если пользователь согласился на обработку персональных данных - он может зарегистрироваться, в обратном случае - нет
            roleBindingSource.DataSource = ListRole;//Осуществляется привязка списка с ролями к элементу управления comboBoxRole
        }

        private void buttonEnrollUser_Click(object sender, EventArgs e)//Нажатие кнопки "Зарегистрироваться"
        {
            try
            {
                bool check = true; //Логическая переменная, проверяющая, а не существует ли уже пользователь с таким же логином
                foreach (User u in Start.ListUser) //Введенный логин сравнивается со всеми существующими пользователями
                    if (textBoxLogin.Text == u.login)
                        check = false; //Если найден пользователь с таким же логином, то переменной проверки присваивается значение false
                if (check) //Проверяется переменная для проверки пользователя. Если она равна false, будет выведено сообщение об ошибке
                {
                    if (textBoxPassword.Text == textBoxPasswordCheck.Text) //Проверяется совпадение введенных паролей. Если они не равны, будет выведено сообщение об ошибке
                    {
                        if ((textBoxAdminCode.Enabled && textBoxAdminCode.Text == enrollCode) || !(textBoxAdminCode.Enabled)) 
                        //Если textBoxAdminCode.Text доступен пользователю, то он должен содержать код администратора, иначе регистрация не произойдет.
                        {
                            int i = (int)comboBoxRole.SelectedValue; //определяется роль пользователя
                            // Происходит создание нового пользователя
                            User newUser = new User(
                                textBoxLogin.Text, //логин
                                textBoxPassword.Text,  //пароль
                                textBoxSurname.Text,  //фамилия
                                textBoxFirstName.Text,  //имя
                                textBoxMiddleName.Text,  //отчество
                                ListRole[i]); //роль
                            Start.ListUser.Add(newUser);//Добавление пользователя в список пользователей
                            Close();//Закрытие формы регистрации
                        }
                        else MessageBox.Show("Для регистрации нового администратора необходимо ввести код администратора", "Ошибка регистрации");
                    }
                    else MessageBox.Show("Пароли не совпадают, пожалуйста, проверьте", "Ошибка регистрации");
                }
                else MessageBox.Show("Такой пользователь уже существует", "Ошибка регистрации");
            }
            catch { MessageBox.Show("Произошла ошибка при регистрации, пропробуйте ещё раз", "Ошибка регистрации"); }
            //Если хоть что-то пошло не так при создании нового пользователя, то будет выдано сообщение об ошибке
        }

        private void textBoxLogin_Click(object sender, EventArgs e)
        {
            //По умолчанию, логин состоит из фамилии и инициалов пользователя. При регистрации пользователь может изменить логин по своему усмотрению
            try { textBoxLogin.Text = textBoxSurname.Text + " " + textBoxFirstName.Text[0] + ". " + textBoxMiddleName.Text[0] + "."; }
            catch { textBoxLogin.Text = ""; } //Если создание строки с фамилией и инициалами невозможно, то логин принимает значение пустой строки
        }

        private void Enroll_FormClosing(object sender, FormClosingEventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();

            //Записываются в файл все роли
            FileStream fsRoleWrite = new FileStream("DataBases/RolesDataBase.bin", FileMode.Create);
            bf.Serialize(fsRoleWrite, ListRole);
            fsRoleWrite.Close();

            //Записываются в файл всех пользователей вместе с только что зарегистрировавшимися
            FileStream fsUserWrite = new FileStream("DataBases/UsersDataBase.bin", FileMode.Create);
            bf.Serialize(fsUserWrite, Start.ListUser);
            fsUserWrite.Close();

            //Записывается в файл код администратора
            FileStream fsCodeWrite = new FileStream("DataBases/EnrollCode.bin", FileMode.Create);
            bf.Serialize(fsCodeWrite, enrollCode);
            fsCodeWrite.Close();
        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*Если выбранный пользователь - администратор, то поле textBoxAdminCode становится доступным для пользователя, 
             * и теперь его необходимо заполнить кодом администратора.
             * Для регистрации любых других пользователей этот элемент остается недоступным, и код администратора не требуется */
            int i = (int)comboBoxRole.SelectedValue;
            if (ListRole[i].roleId == 0)
            {
                textBoxAdminCode.Enabled = true;
            }
            else textBoxAdminCode.Enabled = false;
        }

        private void checkBoxPersonalData_CheckedChanged(object sender, EventArgs e)
        {
            buttonEnrollUser.Enabled = checkBoxPersonalData.Checked;//Если пользователь согласился на обработку персональных данных - он может зарегистрироваться, в обратном случае - нет
        }
    }
}
