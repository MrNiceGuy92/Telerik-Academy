//Problem 1. Say Hello

//Write a method that asks the user for his name and prints “Hello, <name>”
//Write a program to test this method.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SayHello
{
    
    static void Main()
    {
        AskName();
    }
    static void AskName()
    {
        Console.WriteLine("What is your name?");
        string input = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Hello {0}!", input);
    }
}

