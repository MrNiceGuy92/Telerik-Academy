namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Test
    {
        public static void Main()
        {
            var dogArray = new Dog[]
            {
                new Dog() { Name = "Dragan", Age = 17, Sex = "Male" },
                new Dog() { Name = "Penka", Age = 16, Sex = "Female" },
                new Dog() { Name = "Todor", Age = 15, Sex = "Male" },
            };

            var frogArray = new Frog[]
            {
                new Frog("Froggy", 9, "Male"),
                new Frog("Frogster", 4, "Male"),
                new Frog("Frogetta", 10, "Female"),
            };

            var kittenArray = new Kitten[]
            {
                new Kitten("Kit Kat", 12, "Male"),
                new Kitten("Kitty", 3, "Female"),
                new Kitten("Suzi", 10, "Female"),
            };

            var tomCatArray = new TomCat[]
            {
                new TomCat("Tommy", 22, "Male"),
                new TomCat("Jerry", 19, "Male"),
                new TomCat("Batman", 45, "Male"),
            };

            // Average age of Dogs
            Console.WriteLine("Average age of Dogs:");
            Console.WriteLine(GetAvergae(dogArray));
            Console.WriteLine(new string('-', 30));

            // Average age of Frogs
            Console.WriteLine("Average age of Frogs:");
            Console.WriteLine(GetAvergae(frogArray));
            Console.WriteLine(new string('-', 30));

            // Average age of Kittens
            Console.WriteLine("Average age of Kittens:");
            Console.WriteLine(GetAvergae(kittenArray));
            Console.WriteLine(new string('-', 30));

            // Average age of TomCat
            Console.WriteLine("Average age of TomCat:");
            Console.WriteLine(GetAvergae(tomCatArray));
            Console.WriteLine();
        }

        private static double GetAvergae(Animals[] someArray)
        {
            var result = someArray
                .Select(x => x.Age)
                .Average();

            return result;
        }
    }
}