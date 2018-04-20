using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ИС_Книжный_магазин
{
    [Serializable]
    public class Fio
    {
        public string surname; //Фамилия
        public string first_name; //Имя
        public string middle_name; //Отчество
        public string fioFull; //Полное ФИО 
        public string fioInitials; //Фамилия и инициалы

        public Fio(string s, string f, string m)//Конструктор по отдельно введенным фамилии, имени и отчеству
        {
            surname = s;
            first_name = f;
            middle_name = m;
            fioFull = GetFioFull();
            fioInitials = GetFioInitials();
        }

        public Fio(string f)//Конструктор по введенному одной строкой ФИО
        {
            string[] str = f.Split(' ');
            surname = str[0];
            first_name = str[1];
            middle_name = str[2];
            fioFull = GetFioFull();
            fioInitials = GetFioInitials();
        }

        private string GetFioFull()//Из заданных фамилии, имени и отчества генерирует ФИО одной строкой
        {
            string temp = surname + " " + first_name + " " + middle_name;
            return temp;
        }

        private string GetFioInitials()//Из заданных фамилии, имени и отчества генерирует фамилию и инициалы одной строкой
        {
            string temp = surname + " " + first_name[0] + ". " + middle_name[0] + ".";
            return temp;
        }
    }
}