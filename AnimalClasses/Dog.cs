using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClasses
{
    //extend class
    class Dog : Animal, IDomesticated
    {
        public Dog(bool isAlive, int w) : base(isAlive, w)
        {

        }
        public void Talk()
        {
            Console.WriteLine("bark bark");
        }

        public void Sing()
        {
            Console.WriteLine("owwwwwwwww");
        }

        public void Fetch(string thing)
        {
            Console.WriteLine("Here you go. Here is your " + thing + " that was fun lets do it again");
        }

        public void TouchMe()
        {
            Console.WriteLine("Plese scratch behind the ears");
        }

        public void FeedMe()
        {
            Console.WriteLine("Plese feed me");
        }
    }
}
