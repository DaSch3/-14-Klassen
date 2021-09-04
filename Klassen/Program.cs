using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    class Program
    {
        static void Main(string[] args)
        {
            Person janek = new Person();
            Person hendrik = new Person();

            janek.Name = "Janek";
            janek.SageHallo();

            hendrik.Name = "Hendrik";
            hendrik.SageHallo();

            Console.ReadKey();
        
        }
    }

    class Person
    {
        //Eigenschaften
        public string Name { get; set; }
        public int Alter { get; set; }

        //Methoden
        public void SageHallo()
        {
            Console.WriteLine(Name + " sagt: Hallo!");
        }
    }
}
