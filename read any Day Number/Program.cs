using System;

namespace read_any_Day_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Input number to selec day");

            int userImput = 0;

            bool isInt = int.TryParse(Console.ReadLine(), out userImput);


            switch (userImput)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;

                case 2:
                    Console.WriteLine("Tuesday");
                    break;

                case 3:
                    Console.WriteLine("Wendsday");
                    break;

                case 4:
                    Console.WriteLine("Thursday");
                    break;

                case 5:
                    Console.WriteLine("Friday");
                    break;

                case 6:
                    Console.WriteLine("Sadurday");
                    break;

                case 7:
                    Console.WriteLine("Sunday");
                    break;

                default:
                    Console.WriteLine("Error..Pls try again :)");
                    break;

            }
      

            Console.ReadLine();
      
        }
    }
}
