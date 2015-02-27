namespace ParseURL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

//Problem 12. Parse URL

//Write a program that parses an URL address given in the format: 
//[protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.

    class ParseURL
    {
        static void Main()
        {
            string urlAddress = "https://github.com/TelerikAcademy/CSharp-Part-2/blob/master/06.%20Strings%20and%20Text%20Processing/README.md";

            string firstkey = ":";
            int firstIndex = urlAddress.IndexOf(firstkey);

            StringBuilder protocol = new StringBuilder(); //using Stringbuilder for practice

            for (int i = 0; i < firstIndex; i++)
            {
                protocol.Append(urlAddress[i]);
            }

            string secondKey = "/";
            int secondIndex = urlAddress.IndexOf(secondKey, firstIndex + 2);
            int thirdIndex = urlAddress.IndexOf(secondKey, firstIndex + 3);

            StringBuilder server = new StringBuilder();

            for (int i = secondIndex + 1; i < thirdIndex; i++)
            {
                server.Append(urlAddress[i]);
            }

            StringBuilder resource = new StringBuilder();

            for (int i = thirdIndex; i < urlAddress.Length; i++)
            {
                resource.Append(urlAddress[i]);
            }

            if (firstIndex == -1 || secondIndex == -1 || thirdIndex == -1)
            {
                Console.WriteLine("Missing elements in URL!");
                return;
            }

            Console.WriteLine("[protocol] = {0}", protocol);
            Console.WriteLine("[server] = {0}", server);
            Console.WriteLine("[resource] = {0}\n", resource);
        }
    }
}