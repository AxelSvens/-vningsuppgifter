using System.Diagnostics.Tracing;
using System.Security.Cryptography.X509Certificates;

namespace Övningsuppgifter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dag 4, Uppgift 1

            /*Console.WriteLine("Skriv in ett namn:");
            string namn = Console.ReadLine();
            Console.WriteLine("Skriv in hur många loopar som ska göras:");
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                Greetings(namn);
            }
            GenerrateMessage(FullName("Axel", "Svensson"), FullName("Ronja", "Rövardotter"), Medelvärde(19, 29));*/

            //Dag 6, Uppgift 1
            Person p1 = new Person("Axel", "Svensson", 19);
            p1.Greetings();

            //Dag 6, Uppgift 2

            //Skapa lista
            List<Bok> books = new List<Bok>();

            //Skapa böcker
            Bok b1 = new Bok("Lord of the rings", 600);
            Bok b2 = new Bok("Harry Potter", 800);
            Bok b3 = new Bok("Mobby Dick", 450);
            Bok b4 = new Bok("Frankenstien", 350);

            //Lägger till böcker i listan
            books.Add(b1);
            books.Add(b2);
            books.Add(b3);
            books.Add(b4);

            //Skriva ut böcker
            foreach (Bok i in books)
            {
                Console.WriteLine($"{i.title} {i.pages}");
            }

            //Bli rekomenderad en bok
            Bok.recommendBook();

            //Skriv hur många böcker som finns
            Console.WriteLine(Bok.createdBooks);
        }

        static void Greetings(string name)
        {
            Console.WriteLine("Hejsan {0}", name);
        }

        static int Medelvärde(int tal1, int tal2)
        {
            return (tal1 + tal2) / 2;
        }
        static string FullName(string fName, string lName)
        {
            return fName + " " + lName;
        }
        static void GenerrateMessage(string FullName1, string Fullname2, int Medelålder)
        {
            Console.WriteLine("{0} och {1} har en medelålder på {2}", FullName1, Fullname2, Medelålder);
        }
    }
}