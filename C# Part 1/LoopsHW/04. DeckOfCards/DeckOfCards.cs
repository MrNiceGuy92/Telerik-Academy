//Problem 4. Print a Deck of 52 Cards

//Write a program that generates and prints all possible cards from a standard deck of 52 cards 
//(without the jokers). The cards should be printed using the classical notation (like 5 of spades, 
//A of hearts, 9 of clubs; and K of diamonds).
//The card faces should start from 2 to A.
//Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.

using System;

namespace DeckOfCards
{
    class DeckOfCards
    {
        static void Main()
        {
            for (int i = 2; i <= 10; i++)
            {
                for (char j = '\u2660'; j <= '\u2663'; j=(char)(j+3))
                {
                    Console.WriteLine(" {0} of {1}", i, j);
                }
                for (char j = '\u2665'; j <= '\u2666'; j++)
                {
                    Console.WriteLine(" {0} of {1}", i, j);
                }
            }

            for (char j = '\u2660'; j <= '\u2663'; j = (char)(j + 3))
            {
                Console.WriteLine(" A of {0}", j);
                Console.WriteLine(" K of {0}", j);
                Console.WriteLine(" Q of {0}", j);
                Console.WriteLine(" J of {0}", j);
            }

            for (char j = '\u2665'; j <= '\u2666'; j++)
            {
                Console.WriteLine(" A of {0}", j);
                Console.WriteLine(" K of {0}", j);
                Console.WriteLine(" Q of {0}", j);
                Console.WriteLine(" J of {0}", j);
            }
        }
    }
}


            //string[] faces = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            //string[] colours = { "of spades,", "of clubs,", "of hearts,", "of dimonds" };
            //for (int i = 0; i < faces.Length; i++)
            //{
            //    for (int a = 0; a < colours.Length; a++)
            //    {
            //        Console.Write(" {0} {1}", faces[i], colours[a]);
                   
            //    }
            //    Console.WriteLine();
            //}