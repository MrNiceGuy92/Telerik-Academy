namespace StringsInCSharp
{
//Problem 1. Strings in C#.

//Describe the strings in C#.
//What is typical for the string data type?
//Describe the most important methods of the String class.

    class StringsInCSharp
    {
        static void Main()
        {
            /*
            1. A string is a sequence of characters stored in a certain address in memory.
             
            2. Strings are immutable, i.e. after being assigned once, the content of the variable does not change 
            directly- if we try to change the value, it will be saved to a new location in the dynamic memory and the
            variable will point to it.
             
            3. Important String methods: 
             - .CompareTo(..): compares the values of two string to determine their lexicographical order. This method returns
               a negative value if the first string is lexicographically before the secon, 0 if the two strings are equal and 
               a positive value if the second string is lexicographically first;
             - .Concat(..): concatinates two strings;
             - .ToUpper(..)/.ToLower(..): changes characters to upper or lower case:
             - .IndexOf(..): search the string and finds the position of a searched substring;
             - .LastIndexOf(..): same method as above, just starts the search from the end of the string;
             - .Substring(..,..): extracts a substring from the string;
             - .Split(..): splits a string by given separators;
             - .Replace(..,..): replaces a substring with another;
             - .Trim(..): removes unnecessary characters at beginning and at the end of the string;
             - .ToString(..): represents the object of a class or primitive variable as text;
             - /Format(..): formats text and other data through a template.
            */
        }
    }
}
