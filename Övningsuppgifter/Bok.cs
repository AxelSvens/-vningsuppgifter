using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övningsuppgifter
{
    internal class Bok
    {
        //Skapar lista
        public static List<Bok> list = new List<Bok>();

        //Attribut
        public string title;
        public int pages;
        public static int createdBooks = 0;
        public static Random rnd = new Random();

        //Konstruktor
        public Bok(string title, int pages)
        {
            this.title = title;
            this.pages = pages;

            //Ökar antalet skapda böcker
            createdBooks++;

            //Lägger till böcker i en lista
            list.Add(this);
        }

        //Metod som läser boken.
        public void read()
        {

        }

        //Metod som retunerar en slumpmässig bok
        public static void recommendBook()
        {
            int r = rnd.Next(list.Count);
            Console.WriteLine("Jag rekomernderar " + list[r]);
        }
    }
}
