using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Animal
    {
        private string name;
        private string sound;

        public void MakeSound()
        {
            Console.WriteLine($"{name} says {sound}");
        }
        public Animal()
            : this("No Name", "No SOund") { }
        public Animal(string name)
            :this(name,"No Sound") { }
        public Animal(string name,string sound)
        {
            
        }
    }
}
