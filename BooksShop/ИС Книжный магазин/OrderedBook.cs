using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace ИС_Книжный_магазин
{
    [Serializable]
    public class OrderedBook
    {
        public Book book { get; set; }
        public uint number { get; set; }
        public string isbn
        {
            get { return book.isbn; }
        }//международный стандартный номер книги (isbn)
        public string name
        {
            get { return book.name; }
        }//название книги
        public string authorName
        {
            get { return book.authorName; }
        }//имя автора
        public uint price
        {
            get { return book.price; }
        }//цена
        public uint storehouse
        {
            get { return book.storehouse; }
        }//количество книг на складе
        public uint shop
        {
            get { return book.shop; }
        }//количество книг в магазине

        public OrderedBook() { }

        public OrderedBook(Book book, uint number)
        {
            this.book = book;
            this.number = number;
        }
    }
}
