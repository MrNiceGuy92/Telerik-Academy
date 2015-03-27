namespace AnimalHierarchy
{
    using System;

    // I have decided to make the Cat class an abstract class, therefore I won't be able to make an instance of it in Test.cs
    public abstract class Cat : Animals, ISound
    {
        public Cat(string name, int age, string sex)
            : base(name, age, sex)
        {
        }

        public override void ProduceSound(Animals cat)
        {
            Console.WriteLine("The {0} says {1}.", cat.GetType().Name, Sounds.CatMeow);
        }

        protected abstract void SayMeow(Animals animal);
    }
}
