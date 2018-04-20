using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ИС_Книжный_магазин
{
    [Serializable]
    public class Book
    {
        public string isbn { get; set; }  //международный стандартный номер книги (isbn)
        public string name { get; set; } //название книги
        public string authorName { get; set; } //имя автора
        public uint price { get; set; }//цена
        public uint storehouse { get; set; }//количество книг на складе
        public uint shop { get; set; }//количество книг в магазине

        public Book()
        { }

        public Book(string isbn, string name, string authorName, uint price, uint storehouse, uint shop)
        {
            this.isbn = isbn;
            this.name = name;
            this.authorName = authorName;
            this.price = price;
            this.storehouse = storehouse;
            this.shop = shop;
        }
    }
}
