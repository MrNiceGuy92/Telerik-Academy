namespace AnimalHierarchy
{
    using System;

    public class Kitten : Cat, ISound
    {
        public Kitten(string name, int age, string sex) 
            : base(name, age, sex)
        {
        }

        protected override void SayMeow(Animals kitten)
        {
            Console.WriteLine("The {0} says {1}.", kitten.GetType().Name, Sounds.KittenMeow);
        }
    }
}
