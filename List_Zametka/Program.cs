using System;
using System.IO;

namespace List_Zametka
{
    class Program
    {
      
        static void Main(string[] args)

        {

            Console.WriteLine(" Введите заголовок заметки  ");
            string header = System.Console.ReadLine();


            Console.WriteLine(" Введите текст  ");
            string text = System.Console.ReadLine();

            Zametka first = new Zametka(header,text);
        
            Dnevnik my_dnevnik = new Dnevnik();

            my_dnevnik.Add(first);

            my_dnevnik.Show(Console.WriteLine);



            Console.WriteLine("Введите дату заметки, которую хотите редактировать: ");

            int year = int.Parse(System.Console.ReadLine());
            int month = int.Parse(System.Console.ReadLine());
            int day = int.Parse(System.Console.ReadLine());


            DateTime change = new DateTime(year,month,day);
            Console.WriteLine(" Введите новый текст заметки ");
            string text2 = System.Console.ReadLine();
            my_dnevnik.Change(change, text2);

            my_dnevnik.Show(Console.WriteLine);

           // Console.WriteLine("Введите дату заметки, которую хотите удалить: ");

           // int year = int.Parse(System.Console.ReadLine());
           // int month = int.Parse(System.Console.ReadLine());
           // int day = int.Parse(System.Console.ReadLine());


           // DateTime delete = new DateTime(year,month,day);
           //my_dnevnik.Remove(delete);

            Console.WriteLine("Выберите категорию для поиска :\n 1 -  Развлечение\n 2 -  Спорт\n 3 - Работа\n 4 - Учеба\n 5 - Разное ");
            Console.Write("Ваш выбор:");

            int chose = int.Parse(System.Console.ReadLine());

            my_dnevnik.Search_by_Category(chose);


            //my_dnevnik.WriteFile();

            my_dnevnik.Show(Console.WriteLine);

        }
    }
}
