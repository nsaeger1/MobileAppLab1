namespace ConsoleApp1
{
    public class Cat:Pet, Talkable
    {
        private int miceKilled { get; set; }

        public Cat(string name, int miceKilled)
        {
            miceKilled = miceKilled;
            Name = name;
        }

        public void addMouse()
        {
            miceKilled++;
        }

        public string Talk()
        {
            return "Meow";
        }

        public string getName()
        {
            return Name;
        }

        public override string ToString()
        {
            return "Cat: " + "name=" + Name + " mousesKilled=" + miceKilled;;
        }
    }
}