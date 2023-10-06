using System;
using System.Xml;

namespace inluppg3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in en beräkning");
            string input = Console.ReadLine();

            if (input.Contains('-'))
            {
                int left = int.Parse(input[..input.IndexOf('-')]);
                int right = int.Parse(input[(input.IndexOf('-')+1)..]);
                int output = left - right;
                Console.WriteLine(input + " = " +output);
            }
            else if (input.Contains('+'))
            {
                int left = int.Parse(input[..input.IndexOf('+')]);
                int right = int.Parse(input[(input.IndexOf('+') + 1)..]);
                int output = left + right;
                Console.WriteLine(input + " = " + output);
            }
            else
            {
                Console.WriteLine("Fel inmatning");
            }
        }
    }
}