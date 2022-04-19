using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace List_Zametka
{
    class Dnevnik
    {
        public List<Zametka> dnevnik;

        public Dnevnik()
        {

            dnevnik = new List<Zametka>();
            if (File.Exists("dnevnik.txt"))
            {
                dnevnik.AddRange(this.ReadFile());
            }
        }

        public bool Add(Zametka toadd)
        {
            if (dnevnik.FindIndex((user => user.Today == toadd.Today)) == -1)
            {
                dnevnik.Add(toadd);
                return true;
            }

            return false;
        }

        public void Change (DateTime data,string text2)
        {
            int numb = dnevnik.FindIndex((user => user.Today == data.ToShortDateString()));
           
            dnevnik[numb].Text = text2;
        }

        public Zametka Search_by_date(DateTime data)
        {
            int numb = dnevnik.FindIndex((user => user.Today == data.ToShortDateString()));

            return dnevnik[numb]; 
        }


        public void Search_by_Header(string Header)
        {
            int numb = dnevnik.FindIndex(user => user.Header == Header);

            Console.WriteLine(dnevnik[numb]);
        }

        public void Search_by_Category(int ch)

        {

            List<Zametka> search = dnevnik.FindAll(user => user.my_categoria == user[ch-1]);
            search.ForEach(Console.WriteLine);
        }

        public bool Remove(DateTime data) => dnevnik.Remove(this.Search_by_date(data));
        public void Show(Action<Zametka> where) => dnevnik.ForEach(where);
        public List<Zametka>  ReadFile()
        {
            List<Zametka> open = new List<Zametka>();


            string file = File.ReadAllText("dnevnik.txt");
            string[] str = file.Split("\n");
            int count = Convert.ToInt32( str.Count());
           
           
            for (int i = 0; i < count-1;i++ )
            {
               
                Zametka exampl = new Zametka(str[i],str[i+1],str[i + 2], str[i + 3]);
                open.Add(exampl);
                i += 3;
            }
            return open;
        }

        public void WriteFile()
        {
           foreach(Zametka i in dnevnik)
            {
                File.AppendAllText("dnevnik.txt", i.ToString());
            }
        }
        ~ Dnevnik()
        {
            this.WriteFile();
        }
    }
}
