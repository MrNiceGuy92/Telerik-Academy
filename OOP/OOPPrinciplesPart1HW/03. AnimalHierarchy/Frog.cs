namespace AnimalHierarchy
{
    using System;

    public class Frog : Animals, ISound
    {
        public Frog(string name, int age, string sex)
            : base(name, age, sex)
        {
        }

        public override void ProduceSound(Animals frog)
        {
            Console.WriteLine("The {0} says {1}.", frog.GetType().Name, Sounds.Croak);
        }
    }
}
