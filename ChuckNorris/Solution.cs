using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        string MESSAGE = Console.ReadLine();
        string bitMessage = "";
        string answer = "";
        char curChar = '-';

        foreach (char c in MESSAGE)
            bitMessage = String.Concat(bitMessage, Convert.ToString(c, 2).PadLeft(7, '0'));

        Console.Error.WriteLine("Full bits: " + bitMessage);

        foreach (char c in bitMessage)
        {
            Console.Error.WriteLine(c);
            if (curChar == c && curChar != '-')
            {
                answer = String.Concat(answer, "0");
                continue;
            }
            else if (curChar != c && curChar != '-')
            {
                answer = String.Concat(answer, " ");
            }

            if (c == '1')
            {
                answer = String.Concat(answer, "0 0");
                curChar = '1';
            }
            else
            {
                answer = String.Concat(answer, "00 0");
                curChar = '0';
            }
        }

        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(answer);
    }
}