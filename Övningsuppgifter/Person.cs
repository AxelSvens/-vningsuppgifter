using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övningsuppgifter
{
    internal class Person
    {
        //Attribut
        public string firstName;
        public string lastName;
        public int age;
        public Person(string Förnamn, string Efternamn, int Ålder)
        {
            this.firstName = Förnamn;
            this.lastName = Efternamn;
            this.age = Ålder;
        }
        public void Greetings()
        {
            Console.WriteLine($"Hejsan mitt namn är {this.firstName} {this.lastName} och jag är {this.age} år gammal!");
        }
    }
}
