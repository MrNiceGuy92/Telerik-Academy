using System;

namespace IsoscelesTriangle
{
    class IsoscelesTriangle
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            char copyrightSign = '©';

            Console.WriteLine("   " + copyrightSign);
            Console.WriteLine();
            Console.WriteLine("  " + copyrightSign + " " + copyrightSign);
            Console.WriteLine();
            Console.WriteLine(" " + copyrightSign + " " + "  " + copyrightSign);
            Console.WriteLine();
            Console.WriteLine("{0} {1} {2} {3}", copyrightSign, copyrightSign, copyrightSign, copyrightSign);

            //Another Way:
            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            //char copyrightSign = '©';
             
//            Console.WriteLine(@" 
//   ©
//
//  © ©
//
// ©   ©
//
//© © © ©
//");
             
        }
    }
}
