namespace Tests
{
    using Generics;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Points;

    public class TestGeneric
    {
        public static void Main()
        {
            var list = new GenericList<int>(3);
            list.AddElement(5);
            list.AddElement(10);
            list.AddElement(20);

            list.InsertElement(1, 123);

            list.AddElement(9);

            Console.WriteLine(list);

            Console.WriteLine(list.Min());
            Console.WriteLine(list.Max());
           

            
        }
    }
}
