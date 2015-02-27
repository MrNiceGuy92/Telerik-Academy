namespace ReverseSentence_Alternative
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class ReverseSentenceAlternative
    {
        static void Main()
        {

            string sentence = "C# is not C++, not PHP and not Delphi!";

            //Get sentence ending char
            char lastChar = sentence[sentence.Length - 1];

            sentence = sentence.Substring(0, sentence.Length - 1); //Everything, but last char symbol

            string[] words = sentence.Split(' ');

            //Get all comma positions and remove from words
            List<int> commas = new List<int>();
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(","))
                {
                    commas.Add(i);
                    words[i] = words[i].Substring(0, words[i].Length - 1);
                }
            }

            //Reverse words
            Array.Reverse(words);

            //Insert commas at original positions into reversed array
            if (commas.Count > 0)
            {
                for (int i = 0; i < commas.Count; i++)
                {
                    words[commas[i]] += ',';
                }
            }

            //Join reversed words back into sentence
            string reversedSentence = String.Join(" ", words) + lastChar;
            Console.WriteLine(reversedSentence);
        }
    }
}
