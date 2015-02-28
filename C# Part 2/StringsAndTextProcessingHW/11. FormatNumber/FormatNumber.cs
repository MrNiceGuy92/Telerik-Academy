namespace FormatNumber
{
    using System; 
    using System.Text;

//Problem 11. Format number

//Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
//Format the output aligned right in 15 symbols.

    class FormatNumber
    {
        static void Main()
        {
            Console.Write("Input a number: ");
            string input = Console.ReadLine(); ;

            decimal num = decimal.Parse(input);

            Console.WriteLine("Formatted number:");
            Console.WriteLine("{0,15}", num);
            Console.WriteLine("{0,15:X}", int.Parse(input));
            Console.WriteLine("{0,15:P}", (decimal) int.Parse(input) / 100);
            Console.WriteLine("{0,15:E}", int.Parse(input));

        }
    }

}