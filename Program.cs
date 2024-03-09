using System;
using System.Xml.Linq;

namespace Animals
{
    abstract class Animal
    {
        // Property
        public abstract string Name { get; set; }
        // Methods
        public abstract string Describe();
        public string whatAmI()
        {
            return "I'm an animal";
        }
    }
    class Program
    {
        class Mammal : Animal
        {
            public override string Name { get; set; }
            public string Type { get; set; }
            public string Slogan { get; set; }

            public Mammal()
            {
                Name = string.Empty;
                Type = string.Empty;
                Slogan = string.Empty;
            }
            public Mammal(string name, string type, string slogan)
            {
                Name = name;
                Type = type;
                Slogan = slogan;
            }
            public override string Describe()
            {
                return "My name is " + Name + "\nI am a " + Type + ".  " + Slogan;
            }

        }
        static void Main(string[] args)
        {
            Mammal perry = new Mammal();
            perry.Name = "Perry";
            perry.Type = "Platypus";
            perry.Slogan = "Coo coo ca choo.  Yeah, I said it!";
            Console.WriteLine(perry.whatAmI());
            Console.WriteLine(perry.Describe());

            Console.WriteLine();

            Mammal bullwinkle = new Mammal("Bullwinkle", "moose", "Watch me pull a rabbit outa my hat!");
            Console.WriteLine(bullwinkle.whatAmI());
            Console.WriteLine(bullwinkle.Describe());
        }
    }
}