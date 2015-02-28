namespace ExtractTextFromHTML
{
    using System;
    using System.Collections.Generic; 
    using System.Text;

//Problem 25. Extract text from HTML

//Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.

    class ExtractTextFromHTML
    {
        static void Main()
        {
            string input ="<html>" +
                          "<head><title>Great News!!!!</title></head>" +
                          "<body><p><a href=\"http://academy.telerik.com\">Telerik" +
                            "Academy</a> aims to provide free real-world practical" +
                            "training for young people who want to turn into " +
                            "skilful .NET software engineers.</p></body>" +
                        "</html>";
            
            //Extracting title
            string beginTitle = "<title>";
            string endTitle = "</title>";

            if (input.Contains(beginTitle))
            {
                int indexBegin = input.IndexOf(beginTitle);
                int indexEnd = input.IndexOf(endTitle);

                string title = string.Empty;
                while (indexBegin >= 0 && indexEnd > 0)
                {
                    title = input.Substring(indexBegin + beginTitle.Length, indexEnd - indexBegin - beginTitle.Length);
                    input = input.Remove(indexBegin + beginTitle.Length, indexEnd - indexBegin - beginTitle.Length);
                    indexBegin = input.IndexOf(beginTitle, indexBegin + 1);
                    indexEnd = input.IndexOf(endTitle, indexEnd + 1);
                }

                Console.WriteLine("Title: {0}\n", title);
            }
            else
            {
                Console.WriteLine("No title.");
            }
            //Extracting text
            string firstKey = "<";
            string secondKey = ">";

            int firstIndex = input.IndexOf(firstKey);
            int secondIndex = input.IndexOf(secondKey);


            while (firstIndex >= 0 && secondIndex >= 0)
            {
                input = input.Remove(firstIndex, secondIndex - firstIndex + 1);

                firstIndex = input.IndexOf(firstKey);
                secondIndex = input.IndexOf(secondKey);
            }

            
            Console.WriteLine("Text: {0}", input);
        }
    }
}
