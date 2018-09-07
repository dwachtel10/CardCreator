using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardCreator.UI
{
    public class ConsoleIO
    {
        public static string GetRequiredStringFromUser(string prompt)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("You must enter valid text.");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
            }

            return input;
        }

        public static int GetRequiredIntFromUser(string prompt)
        {
            int numberResult;
            Console.WriteLine(prompt);
            while (!int.TryParse(prompt, out numberResult) || numberResult <= 0)
            {

                Console.WriteLine("Enter a positive number.");
                prompt = Console.ReadLine();

            }
            return numberResult;
        }

    }
}
