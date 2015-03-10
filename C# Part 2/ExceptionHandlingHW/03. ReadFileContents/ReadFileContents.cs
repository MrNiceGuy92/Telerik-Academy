namespace ReadFileContents
{
    //Problem 3. Read file contents

    //Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
    //Find in MSDN how to use System.IO.File.ReadAllText(…).
    //Be sure to catch all possible exceptions and print user-friendly error messages.

    using System;
    using System.IO;
    using System.Security;
    using System.Text;

    class ReadFileContents
    {
        static void Main()
        {
            string filePath = @"C:\WINDOWS\win"; //use exampe or input own path

            try
            {
                string readText = File.ReadAllText(filePath);
                Console.WriteLine(readText);
            }

            //Exceptions
            catch (ArgumentNullException)
            {
                Console.WriteLine("Argument is NULL.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Argument Exception.");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Path is too long.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Directory not found.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Unauthorized Access.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Path is in an invalid format.");
            }
            catch (SecurityException)
            {
                Console.WriteLine("Security Exception.");
            }
            catch (IOException)
            {
                Console.WriteLine("An I/O error occurred while opening the file.MJ");
            }
        }
    }
}
