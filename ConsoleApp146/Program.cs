using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp146
{
    class Program
    {
        static void Main(string[] args)
        {
            var string1 = "hello there";
            var characterArray = new char[5];

            Console.WriteLine($"string1:\"{string1}\"");

            Console.WriteLine($"Length of string1:{string1.Length}");
            Console.ReadLine();

            Console.Write("The string reversed is: ");

            for (int i = string1.Length - 1; i >= 0; --i)
            {
                Console.WriteLine(string1[i]);
                Console.ReadLine();
            }

            string1.CopyTo(0, characterArray, 0, characterArray.Length);
            Console.Write("\nThe character array is:");
            Console.ReadLine();

            foreach (var element in characterArray)
            {
                Console.Write(element);
            }
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
