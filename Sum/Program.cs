using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, number, sum;
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
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("number1 = " + number1 + "\nnumber2 = " + number2);
            sum = number1 + number2;
            //Console.WriteLine("Sum of "+number1+" va "+number2+" is "+sum); 
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(number1 + " + " + number2 + " = " + sum);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
