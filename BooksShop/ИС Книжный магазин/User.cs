using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ИС_Книжный_магазин
{
    [Serializable]
    public class User
    {
        public string login { get; set; } //Логин пользователя
        public string password { get; set; }//Пароль пользователя
        public string userSurname { get; set; } //Фамилия пользователя
        public string userFirstName { get; set; } //Имя пользователя
        public string userMiddleName { get; set; } //Отчество пользователя
        public Role userRole { get; set; } //Роль пользователя
        public string roleName //Наименование роли пользователя
        {
            get
            {
                try { return userRole.roleName; }
                catch { return ""; }
            }
            set
            {
                if (userRole == null)
                    userRole = new Role();
                userRole.roleName = value;
            }
        }
        public int roleId //ID роли пользователя
        {
            get
            {
                try { return userRole.roleId; }
                catch { return 0; }
            }
            set
            {
                if (userRole == null)
                    userRole = new Role();
                userRole.roleId = value;
            }
        }

        public User()
        { }
              
        public User(string login, string password, string surname, string first_name, string middle_name, Role userRole)
        {
            this.login = login;
            this.password = password;
            this.userRole = userRole;
            userFirstName = first_name;
            userMiddleName = middle_name;
            userSurname = surname;
        }
    }
}
