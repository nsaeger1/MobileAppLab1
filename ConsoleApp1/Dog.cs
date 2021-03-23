using System;

namespace ConsoleApp1
{
    public class Dog : Pet, Talkable

    {
        private Boolean Friendly { get; }
        
        public Dog(string name, Boolean friendly) 
        {
            Friendly = friendly;
            Name = name;
        }
        
        public string Talk()
        {
            return "Bark";
        }

        public string getName()
        {
            return Name;
        }

        public override string ToString()
        {
            return "Dog: " + "name=" + Name + " friendly=" + Friendly;
        }
    }
}