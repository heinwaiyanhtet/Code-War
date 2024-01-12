using System;
using System.Collections.Generic;

namespace Solution
{
    class Program
  {
    static void Main()
    {
        long[] reversedArray = Digitize(35231);
        
        Console.WriteLine("Reversed Array: [" + string.Join(",", reversedArray) + "]");
    }


     public static long[] Digitize(long n)
        {
            string numberString = n.ToString();

            List<long> reversedDigits = new List<long>();

            // Loop through each character in the string (in reverse order)
            for (int i = numberString.Length - 1; i >= 0; i--)
            {
                // Parse the character to a digit and add to the list
                reversedDigits.Add(long.Parse(numberString[i].ToString()));
            }

            Console.WriteLine($"reversedDigits ,{reversedDigits}");

            return reversedDigits.ToArray();
        }
  }
}