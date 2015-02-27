namespace ExtractEmails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    //Problem 18. Extract e-mails

    //Write a program for extracting all email addresses from given text.
    //All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.

    class ExtractEmails
    {
        static void Main()
        {
            string someInput = "Trainers at Telerik: Nikolay.Kostov@telerik.com, Ivaylo.Kenov@telerik.com," +
            " Doncho.Minkov@telerik.com, Evlogi.Hristov@telrik.com and others.";

            string[] splitInput = someInput.Split(' ');
            var results = new List<string>();

            for (int i = 0; i < splitInput.Length; i++)
            {
                if (splitInput[i].Contains('@'))
                {
                    splitInput[i] = splitInput[i].Replace(',', ' ');

                    results.Add(splitInput[i]);
                }
            }

            foreach (string email in results)
            {
                Console.WriteLine(email);
            }
        }
    }

}
