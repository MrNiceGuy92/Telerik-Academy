namespace EnterNumbers
{
    //Problem 2. Enter numbers

    //Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
    //If an invalid number or non-number text is entered, the method should throw an exception.
    //Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

    using System;
    using System.Text;

    class EnterNumbers
    {
        static void Main()
        {
            int start = 1; //Lower bound
            int end = 100; //Upper bound

            int[] sequence = new int[10];
            for (int i = 0; i < 10; i++)
            {
               sequence[i] = ReadNumber(start, end);
               start = sequence[i];
            }

            //Printing
            foreach (int number in sequence)
            {
                Console.WriteLine(number);
            }
        }

        static int ReadNumber(int start, int end)
        {
            try
            {
                Console.Write("Enter number: ");
                int someInt = int.Parse(Console.ReadLine());
                if (someInt < start || someInt > end)
                {
                    throw new ArgumentOutOfRangeException(
                        String.Format("The number you have entered is not in the range [{0}-{1}]", start, end));
                }

                return someInt;
            }
            catch (FormatException)
            {
                throw new FormatException(String.Format("The number you have entered is NOT of type int."));
            }
        }
    }
}
