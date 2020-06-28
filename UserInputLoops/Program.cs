using System;

namespace UserInputLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int validatedInt = Prompt.promptForInt();
            validatedInt = Prompt.promptForIntBetween1And9();

            Console.WriteLine("Thank you for entering the number " + validatedInt.ToString());
        }


    }
}
