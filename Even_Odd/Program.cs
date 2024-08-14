using System;

namespace Even_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Please Enter Number:");
            bool flag = int.TryParse(Console.ReadLine(), out number);
            while (flag == false)
            {
                Console.WriteLine("Please Enter Correct Number!");
                flag = int.TryParse(Console.ReadLine(), out number);
            }
            if (number % 2 == 0)
                Console.WriteLine(number + " is even");
            else
                Console.WriteLine(number + " is odd");
        }
    }
}
