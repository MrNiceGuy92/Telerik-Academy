//Problem 2. Bonus Score

//Write a program that applies bonus score to given score in the range [1…9] by the following rules:
//If the score is between 1 and 3, the program multiplies it by 10.
//If the score is between 4 and 6, the program multiplies it by 100.
//If the score is between 7 and 9, the program multiplies it by 1000.
//If the score is 0 or more than 9, the program prints “invalid score”.

using System;

namespace BonusScore
{
    class BonusScore
    {
        static void Main()
        {
            Console.Write("Write a score in the range [0..9]: ");
            int initialScore = int.Parse(Console.ReadLine());
            
            bool firstCase = (1<=initialScore) && (initialScore<=3);
            bool secondCase = (4<=initialScore) && (initialScore<=6);
            bool thirdCase = (7<=initialScore) && (initialScore<=9);

            Console.WriteLine();

            if (firstCase)
            {
                Console.WriteLine("Your new score: {0}",initialScore * 10);
                Console.WriteLine();
            }
            else if (secondCase)
            {
               Console.WriteLine("Your new score: {0}",initialScore * 100);
               Console.WriteLine();
            }
            else if (thirdCase)
            {
                Console.WriteLine("Your new score: {0}", initialScore * 1000);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid score.");
                Console.WriteLine();
            }
        }
    }
}
