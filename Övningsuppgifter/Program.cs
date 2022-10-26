using System.Security.Cryptography.X509Certificates;

namespace Övningsuppgifter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dag 4, Uppgift 1

            Console.WriteLine("Skriv in ett namn:");
            string namn = Console.ReadLine();
            Console.WriteLine("Skriv in hur många loopar som ska göras:");
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                Greetings(namn);
            }
            GenerrateMessage(FullName("Axel", "Svensson"), FullName("Ronja", "Rövardotter"), Medelvärde(19, 29));

            //Dag 6, Uppgift 1
            Person p1 = new Person("Axel", "Svensson", 19);
            p1.Greetings();
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