using System;

namespace GetInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstName, LastName, Gender, MobileNumber;
            int Age, Year;
            ulong Number=0;
            int ThisYear = 1403;
            bool isnumber,flag,check;
            Console.WriteLine("Please Enter Your First Name!");
            FirstName = Console.ReadLine();
            while (FirstName == "")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nPlease Enter Your First Name");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Gray;
                FirstName = Console.ReadLine();
            }

            Console.WriteLine("\nPlease Enter Your Last Name!");
            LastName = Console.ReadLine();
            while (LastName == "")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nPlease Enter Your Last Name");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Gray;
                LastName = Console.ReadLine();
            }
            Console.WriteLine("\nPlease Enter Your birth Year!");
            isnumber = int.TryParse(Console.ReadLine(), out Year);
            while (isnumber == false)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nPlease Enter Your birth Year Corectly!");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Gray;
                isnumber = int.TryParse(Console.ReadLine(), out Year);
            }
            Age = ThisYear - Year;

            Console.WriteLine("\nPlease Enter 'F' for Female OR 'M' for Male");
            Gender = Console.ReadLine();
            while (Gender != "F" && Gender != "M")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nPlease Enter 'F' for Female OR 'M' for Male");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Gray;
                Gender = Console.ReadLine();
            }
            if (Gender == "F")
                Gender = "Femail";
            else if (Gender == "M")
                Gender = "Male";
            isnumber = false;
            flag = false;
            check = false;
            Console.WriteLine("\nPlease Enter Your Mobile Number!");
            while (flag != true || isnumber != true || check != true)
            {
                MobileNumber = Console.ReadLine();
                flag = MobileNumber.StartsWith("09");
                isnumber = ulong.TryParse(MobileNumber, out Number);
                if (flag == false)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n! Your Mobile Number should be start with 09!");
                }
                    
                if (isnumber == false)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n! Please Enter Your MobileNumber Corectly");
                }
                    
                if (MobileNumber.Length != 11)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n! Your MobileNumber Lenght Should be 11 digit");
                    check = false;
                }
                else
                    check = true;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nYour Name is : " + FirstName + " " + LastName);
            Console.WriteLine("\nYour Mobile Number is : "+ Number);
            Console.WriteLine("\nYou Are " +Gender+" and You Are "+ Age + " Year's Old\n") ;

            if (Gender == "Femail" && Age >= 15)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You Can Register in Our Site.");
            }
            else if (Gender == "Male" && Age >= 18)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You Can Register in Our Site.\n");
            }
                
            else
            {
                Console.BackgroundColor=ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("You Can Not Register in Our Site.\n");
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
