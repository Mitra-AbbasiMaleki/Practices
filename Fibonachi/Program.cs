using System;

namespace Fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
           int count = 12;
            int[] fibo = new int[count];
            fibo[0] = 1;
            fibo[1] = 1;
            for (int i = 2; i < count; i++)
            {
                fibo[i] = fibo[i - 1] + fibo[i - 2];
            }
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < count - 1; i++)
                Console.Write(fibo[i] + " , ");
            Console.Write(fibo[count - 1] + "\n");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
