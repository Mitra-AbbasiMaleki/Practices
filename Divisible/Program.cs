using System;

namespace Divisible
{
    class Program
    {
        static void Main(string[] args)
        {
           int number1, number2, number;
            Console.WriteLine("Please Enter First Number:");
            bool flag = int.TryParse(Console.ReadLine(), out number);
            while (flag == false)
            {
                Console.WriteLine("Please Enter Correct Number!");
                flag = int.TryParse(Console.ReadLine(), out number);
            }
            number1 = number;
            Console.WriteLine("Please Enter Second Number:");
            flag = int.TryParse(Console.ReadLine(), out number);
            while (flag == false)
            {
                Console.WriteLine("Please Enter Correct Number!");
                flag = int.TryParse(Console.ReadLine(), out number);
            }
            number2 = number;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("number1 = " + number1 + "\nnumber2 = " + number2);

            if (number1 > number2)
                number = number1 % number2;
            else
                number = number2 % number1;

            if (number == 0)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(number1 + " va " + number2 + " bar ham bakhshpazir hastand");
            }    
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(number1 + " va " + number2 + " bar ham bakhshpazir nistand");
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
