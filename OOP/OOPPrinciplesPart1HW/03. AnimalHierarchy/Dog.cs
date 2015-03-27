namespace AnimalHierarchy
{
    using System;

    public class Dog : Animals, ISound
    {
        public Dog(string name, int age, string sex) 
            : base(name, age, sex)
        {
        }

        public Dog()
        {
        }  

        public override void ProduceSound(Animals dog)
        {
            Console.WriteLine("The {0} says {1}.", dog.GetType().Name, Sounds.Bark);
        }
    }
}
