using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var zoo = new ArrayList();
            zoo.Add(new Cat("Charlie", 9));
            zoo.Add(new Dog( "Bean", true));
            zoo.Add(new Teacher( "Stacy Read", 44));

            foreach (Talkable thing in zoo)
            {
                printOut(thing);
            }
        }

        public static void printOut(Talkable p)
        {
            Console.WriteLine(p.getName() + " says=" + p.Talk());
        }
    }
}