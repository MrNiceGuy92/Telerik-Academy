using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinaryToHexidecimalEASY
{
    static void Main()
    {
        //Easy way 

        Console.Write("Input binary number: ");
        string input = Console.ReadLine();
        Console.Write("Hexidecimal result: ");
        Console.WriteLine(HexConverted(input));
    }

    static string HexConverted(string strBinary)
    {
        string strHex = Convert.ToInt32(strBinary, 2).ToString("X");
        return strHex;
    }
}
