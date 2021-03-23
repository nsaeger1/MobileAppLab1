namespace ConsoleApp1
{
    public class Teacher:Person,Talkable
    {
        private int Age { get; set; }

        public Teacher(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Talk()
        {
            return "Don't forget to do the assigned reading!";
        }

        public string getName()
        {
            return Name;
        }
    }
}