using System;
using System.Collections.Generic;
using System.Text;

namespace UserInputLoops
{
    public class Prompt
    {
        public static int promptForInt()
        {
            int parsedInput;
            bool isInt;
            do
            {
                Console.WriteLine("Enter a number:");
                string input = Console.ReadLine();

                isInt = int.TryParse(input, out parsedInput);

                //Add error messages to help your user figure it out
                if (!isInt)
                {
                    Console.WriteLine("Try again, but at least enter a number this time.");
                }

            } while (!isInt);
            return parsedInput;
        }

        public static int promptForIntBetween1And9()
        {
            int parsedInput;
            do
            {
                Console.WriteLine("Enter a number between 1 and 9");//0 and 10 are bad
                string input = Console.ReadLine();
                //explicit version with exception handling (exception means error)
                //try
                //{
                //    parsedInput = int.Parse(input);
                //} catch (Exception e)
                //{
                //    Console.WriteLine(e.Message);
                //}

                //elegant version, but without error handling.
                bool isInt = int.TryParse(input, out parsedInput);

                //Add error messages to help your user figure it out
                if (!isInt)
                {
                    Console.WriteLine("Try again, but at least enter a number this time.");
                }
                if (parsedInput < 1 && parsedInput != 0)
                {
                    Console.WriteLine("Almost there, pick a higher number.");
                }
                if (parsedInput > 9)
                {
                    Console.WriteLine("Almost there, pick a lower number.");
                }

            } while (parsedInput > 10 || parsedInput < 1);
            return parsedInput;
        }
    }
}
