namespace ReplaceTags
{
    using System;
    using System.Collections.Generic;
    using System.Text;

//Problem 15. Replace tags

//Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].

    class ReplaceTags
    {
        static void Main()
        {
            string input = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";

            input = input.Replace("</a>", "[/URL]");

            string keyword = "<a href=\"";
            string secondKey = "\">";

            int index = input.IndexOf(keyword);
            int secondIndex = input.IndexOf(secondKey);

            var url = new List<string>(); //List to add urls from input text

            while (index > 0 && secondIndex > 0)
            {
                string someSub = string.Empty;
                someSub = input.Substring(index + keyword.Length, secondIndex - index - keyword.Length); //substrings of urls from input
                url.Add(someSub);
                index = input.IndexOf(keyword, index + 1);
                secondIndex = input.IndexOf(secondKey, secondIndex + 1);
            }

            for (int i = 0; i < url.Count; i++)
            {
                input = input.Replace(keyword + url[i] + secondKey, "[URL]" + url[i] + "[/URL] ");
            }

            Console.WriteLine(input);
        }
    }

}

//Alternative solution
//string html = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";

//            string html1 = "<a href=\"";
//            string html2 = @""">";
//            string html3 = "</a>";
//            string url1 = "[URL=";
//            string url2 = "]";
//            string url3 = "[/URL]";

//            while (html.Contains(html1))
//                html = html.Replace(html1, url1);
//            while (html.Contains(html2))
//                html = html.Replace(html2, url2);
//            while (html.Contains(html3))
//                html = html.Replace(html3, url3);

//            Console.WriteLine(html);