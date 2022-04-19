using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Zametka
{
    class Zametka
    {
        public string Today { get; set; }
        public string Header { get; set; }

        public string Text { get; set; }

        public string[] Category=new string [5];
        public string my_categoria;

        public Zametka( )
        {
           
            Category[0] = " Развлечение ";
            Category[1] = " Спорт ";
            Category[2] = " Работа ";
            Category[3] = " Учеба ";
            Category[4] = " Разное ";

        }

        public Zametka(string header, string text):this()
        {
            Today = DateTime.Now.ToShortDateString();
            Header = header;
            Text = text;

            Console.WriteLine("Выберите категорию:\n 1 -  Развлечение\n 2 -  Спорт\n 3 - Работа\n 4 - Учеба\n 5 - Разное ");
            Console.Write("Ваш выбор:");

            int ch = int.Parse(System.Console.ReadLine());
            my_categoria = this[ch-1];
        }
        public Zametka(string today, string categoria,string header, string text) : this()
        {
            Today = today;
            Header = header;
            Text = text;
            my_categoria = categoria;
        }

        public string this[int ind]
        {
            get { return Category[ind]; }
          //  set {  }
        }

        public override string ToString()
        {
            return ($" {this.Today}\n{ my_categoria}\n{this.Header}\n{this.Text}\n");
        }
    }
}
