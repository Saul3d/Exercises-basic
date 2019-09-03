using System;
using System.Globalization;

namespace numberMultipliers
{
    class Program
    {
        static void Main(string[] args)     
        {
            Console.WriteLine("Would you like to Multiply or Square an array of numbers");
            var usersOperatorChoice = Console.ReadLine().ToLower();

            if (usersOperatorChoice == "multiply")
            {
                Console.WriteLine("Please enter a comma separated list of numbers");
                var input = Console.ReadLine();
                var numbers = input.Split(",");

                var multiplyNumbers = 1;

                for (var i = 0; i < numbers.Length; i++)
                {
                    multiplyNumbers *= int.Parse(numbers[i]);
                }
                Console.WriteLine(multiplyNumbers);
            }
            else if (usersOperatorChoice == "square")
            {
                Console.WriteLine("Please enter a comma separated list of numbers");
                var input = Console.ReadLine();
                var numbers = input.Split(",");


                for (var i = 0; i < numbers.Length; i++)
                {
                    var numberSquared = int.Parse(numbers[i]);
                    Console.WriteLine(numberSquared * numberSquared);
                }
            }
            else
            {
                Console.WriteLine("You must enter \"Multiply\" or \"Square\"");
            }

        }
    }
}
