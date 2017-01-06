using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gladiators.Helpers
{
    public static class ConsoleHelpers
    {
        public static int ReadIntInput()
        {
            string inputValue = "";
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);
                if (key.Key != ConsoleKey.Backspace)
                {
                    double val = 0;
                    bool wasParsed = double.TryParse(key.KeyChar.ToString(), out val);
                    if (wasParsed)
                    {
                        inputValue += key.KeyChar;
                        Console.Write(key.KeyChar);
                    }
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && inputValue.Length > 0)
                    {
                        inputValue = inputValue.Substring(0, (inputValue.Length - 1));
                        Console.Write("\b \b");
                    }
                }
            }
            // Stops Receving Keys Once Enter is Pressed
            while (key.Key != ConsoleKey.Enter || inputValue.Length<1);
            Console.WriteLine();
            return Convert.ToInt32(inputValue);
        }
    }
}
