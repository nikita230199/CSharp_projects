using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreeViewЦиклыОтбор
{
    class Auto
    {
        string марка;

        public string Марка
        {
            get { return марка; }
            set { марка = value; }
        }
        string кузов;

        public string Кузов
        {
            get { return кузов; }
            set { кузов = value; }
        }
        string коробка;

        public string Коробка
        {
            get { return коробка; }
            set { коробка = value; }
        }
        string цвет;

        public string Цвет
        {
            get { return цвет; }
            set { цвет = value; }
        }

       
            

        public Auto(string марка1, string кузов1, string коробка1, string цвет1)
        {
          Марка   = марка1;
          Кузов   = кузов1;
          Коробка = коробка1;
          Цвет    = цвет1;
        }

    }
}
