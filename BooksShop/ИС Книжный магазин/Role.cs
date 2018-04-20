using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ИС_Книжный_магазин
{
    [Serializable]
    public class Role
    {
        public int roleId { get; set; }//индекс роли
        /*id роли не является уникальным идентификатором, определяющим роль. 
         * Он является индексом для перехода а соответствующую пользователю форму в форме Start*/
        public string roleName { get; set; }//название роли

        public Role() { }

        public Role(int roleId, string roleName)//Конструктор с ручным индексированием ролей
        {
            this.roleName = roleName;
            this.roleId = roleId;
        }
    }
}
