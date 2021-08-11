using System;
using System.Collections.Generic;

namespace JobNimbus
{
    public class Brackets
    {
        static void Main(string[] args)
        {
            var keepGoing = "y";

            Console.WriteLine("Welcome to the Balancing Brackets Checker!");

            while (keepGoing.Equals("y"))
            {
                Console.WriteLine("Enter your brackets: ");
                var input = Console.ReadLine();
                var response = doBracketsMatch(input);

                if (response)
                {
                    Console.WriteLine("The brackets match!");
                }
                else
                {
                    Console.WriteLine("Too bad - the brackets don't match :(");
                }

                Console.WriteLine("Would you like to try again? (y/n)");
                keepGoing = Console.ReadLine();
            }
        }

        public static bool doBracketsMatch(string input)
        {
            var stack = new Stack<Char>();

            foreach (var character in input)
            {
                if (character.Equals('{'))
                {
                    stack.Push(character);
                }
                else if (character.Equals('}'))
                {
                    if (stack.Count <= 0)
                    {
                        return false;
                    }

                    stack.Pop();
                }
            }

            if (stack.Count != 0)
            {
                return false;
            }

            return true;
        }
    }
}
