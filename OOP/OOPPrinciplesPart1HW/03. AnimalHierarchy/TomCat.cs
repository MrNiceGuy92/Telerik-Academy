namespace AnimalHierarchy
{
    using System;

    public class TomCat : Cat, ISound
    {
        public TomCat(string name, int age, string sex)
            : base(name, age, sex)
        {
        }

        protected override void SayMeow(Animals tomCat)
        {
            Console.WriteLine("The {0} says {1}.", tomCat.GetType().Name, Sounds.TomCatMeow);
        }
    }
}
