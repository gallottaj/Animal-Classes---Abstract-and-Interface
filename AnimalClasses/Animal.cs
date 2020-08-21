using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClasses
{
    //cannot make an instance of an abstract class
    abstract class Animal
    {
        Boolean isAlive { get; set; }
        int weight { get; set; }

        public Animal ()
        {
            Console.WriteLine("Animal Constructor");
        }

        public Animal (Boolean isAlive, int w)
        {
            this.isAlive = isAlive;
            this.weight = w;
        }

        public void Greet()
        {
            Console.WriteLine("Animal greeting");

        }

        public void Talk()
        {
            Console.WriteLine("Animal says things");

        }

        public void Sing()
        {
            Console.WriteLine("Animal is singing");

        }

        public string ToString()
        {
            return "Status: " + isAlive + " weight: " + weight;
        }

    }
}
