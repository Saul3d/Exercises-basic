using System;
using System.Globalization;

namespace LetterLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Console.WriteLine("input: " + input);
            string inputWithRemovedSpaces = input.Replace(" ", "");
            var compositechar = "";
            for (int k = 0; k < inputWithRemovedSpaces.Length; k++)
            {
                int h = 0; var tmp = "";
                while (h <= k)
                {
                    tmp += string.Concat((h == 0) ? (char.ToUpper(inputWithRemovedSpaces[k])) : char.ToLower(inputWithRemovedSpaces[k]));
                    h++;
                }
                compositechar += tmp + '-';
            }
            Console.WriteLine("output: " + compositechar.Trim('-'));
            Console.WriteLine(DateTime.Now);
        }
    }
}
