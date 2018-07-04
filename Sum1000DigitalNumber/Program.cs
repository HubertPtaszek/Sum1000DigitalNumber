using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum1000DigitalNumber
{
    public class Program
    {
        enum numberSource
        {
            RandomNumber,
            FromFileNumber,
            FromParameterNumber
        }

        static void Main(string[] args)
        {
            //MainMenu.Start_menu();

            string number1 = "";
            string number2 = "";

            if (Int32.Parse(args[0]) == (int)numberSource.RandomNumber)
            {
                RandomNumber randomNumber1 = new RandomNumber();
                number1 = Operations.ConvertNumbers(randomNumber1);
                Console.WriteLine($"Pierwsza liczba: {number1}");

                RandomNumber randomNumber2 = new RandomNumber();
                number2 = Operations.ConvertNumbers(randomNumber2);
                Console.WriteLine($"\nDruga liczba: {number2}");
            }
            else if (Int32.Parse(args[0]) == (int)numberSource.FromFileNumber)
            {
                FromFileNumber fileNumber1 = new FromFileNumber("data.txt", 1);
                number1 = Operations.ConvertNumbers(fileNumber1);
                Console.WriteLine($"Pierwsza liczba: {number1}");

                FromFileNumber fileNumber2 = new FromFileNumber("data.txt", 2);
                number2 = Operations.ConvertNumbers(fileNumber2);
                Console.WriteLine($"\nDruga liczba: {number2}");
            }
            else if (Int32.Parse(args[0]) == (int)numberSource.FromParameterNumber)
            {
                number1 = args[1];
                Console.WriteLine($"Pierwsza liczba: {number1}");
                number2 = args[2];
                Console.WriteLine($"\nDruga liczba: {number2}");
            }
            else
                Console.Error.WriteLine("Niepoprawny paramter aplikacji");

            Console.WriteLine($"\nSuma liczb: {SumNumber.sumNumber(number1, number2)}");
            Console.ReadKey();
        }
    }
}
