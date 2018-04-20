using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ИС_Книжный_магазин
{
    [Serializable]
    public class Order
    {
        public string number { get; set; } //Номер заказа
        public DateTime date { get; set; } //Дата заказа
        public List<OrderedBook> orderedBooks { get; set; }
        public uint sum //Сумма заказа
        {
            get
            {
                uint s = 0;
                for (int i = 0; i < orderedBooks.Count; i++)
                    s += orderedBooks[i].price * orderedBooks[i].number;
                return s;
            }
        }
        public User user { get; set; } //Пользователь, заказавший книги
        //ФИО не реализовано через свойство User, так как заказчик может не являться держателем аккаунта - например в семье заказывает несколько разных человек через один аккаунт
        public string userSurname { get; set; } //Фамилия
        public string userFirstName { get; set; } //Имя
        public string userMiddleName { get; set; } //Отчество
        public string phoneNumber { get; set; } //Телефон
        public bool delivery { get; set; } //Заказал ли пользователь доставку (true - да, false - нет)
        private string adressDelivery; //Адрес, на который следует привести книги
        public string adress
        {
            get
            {
                if (delivery)
                    return adressDelivery;
                else return " ";
            }
            set
            {
                adressDelivery = value;
            }
        } //Адрес, на который следует привести книги
        private int osNum;//Индекс статуса заказа (индекс из массива соответствующего данному заказу статуса)
        public int orderStatusNum //Свойство индекса статуса заказа
        {
            get { return osNum; }
            set
            {
                if (value < statuses.Length && value >= 0)
                    osNum = value;
                else osNum = 0;
            }
        }
        public string orderStatus //Свойство названия статуса заказа
        {
            set
            {
                for (int i = 0; i < statuses.Length; i++)
                    if (value == statuses[i]) orderStatusNum = i;
            }
            get { return statuses[orderStatusNum]; }
        }

        public static string[] statuses = {"Заказ принят", "Заказ в процессе обработки" , "Заказ подготовлен к выдаче", "Заказ доставляется", "Заказ закрыт"};
        /* Основные виды статусов заказа: 
             * 0 - заказ принят магазином 
             * 1 - заказа пока что нет в наличии, ждет доставки со склада
             * 2 - заказан на самовывоз, находится в магазине, ждет когда его заберут
             * 3 - заказан с доставкой, находится в процессе доставки
             * 4 - заказ получен покупателем (заказ закрыт)*/

        public Order()
        { }

        public Order(string number, List<OrderedBook> orderedBooks, User user, string userSurname, string userFirstName, string userMiddleName, string phoneNumber, bool delivery, string adress)
        {
            this.number = number;
            date = DateTime.Today;
            this.orderedBooks = orderedBooks;
            this.user = user;
            this.userSurname = userSurname;
            this.userFirstName = userFirstName;
            this.userMiddleName = userMiddleName;
            this.phoneNumber = phoneNumber;
            this.delivery = delivery;
            this.adress = adress;
            orderStatusNum = 0;
        }

        public Order(string number, DateTime date, List<OrderedBook> orderedBooks, User user, string userSurname, string userFirstName, string userMiddleName, string phoneNumber, bool delivery, string adress, int orderStatusNum)
        {
            this.number = number;
            this.date = date;
            this.orderedBooks = orderedBooks;
            this.user = user;
            this.userSurname = userSurname;
            this.userFirstName = userFirstName;
            this.userMiddleName = userMiddleName;
            this.phoneNumber = phoneNumber;
            this.delivery = delivery;
            this.adress = adress;
            this.orderStatusNum = orderStatusNum;
        }

        public void LoadOut(string path)
        {
            //Метод, производящий выгрузку объекта в файл
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine("Номер заказа: " + number.ToString());
            sw.WriteLine("Дата заказа: " + date.ToShortDateString());
            sw.WriteLine();
            sw.WriteLine("Персональные данные: ");
            sw.WriteLine("ФИО: " + userSurname + " " + userFirstName + " " + userMiddleName);
            sw.WriteLine("Телефон: " + phoneNumber);
            if (delivery)
                sw.WriteLine("Способ доставки: Доставка по адресу: " + adress);
            else sw.WriteLine("Способ доставки: Самовывоз");
            sw.WriteLine();
            sw.WriteLine("Заказ: ");
            for (int i = 0; i < orderedBooks.Count; i++)
                sw.WriteLine(orderedBooks[i].book.name + ", " + orderedBooks[i].book.authorName + "; " + orderedBooks[i].number + " шт.");

            sw.WriteLine();
            sw.WriteLine("Сумма заказа: " + sum.ToString());
            sw.Close();
        }
    }
}
