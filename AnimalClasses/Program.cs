using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            Dog fido = new Dog(false, 25);

            fido.Greet();
            fido.Talk();
            fido.Sing();
            fido.Fetch("stick");
            fido.TouchMe();
            fido.FeedMe();

            Console.WriteLine(fido.ToString());

            Robin red = new Robin();
            red.Talk();
            red.Sing();

            //horse
            Horse h = new Horse();
            h.Ride();

            //cow
            Cow c = new Cow();
            c.Milk();

            //goat
            Goat g = new Goat();
            g.Milk();

            Console.ReadLine();
        }
    }
}
