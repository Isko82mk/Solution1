using System;

namespace sumAndAverageFrom_Keyboard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            double sum = 0;
            double[] randomNumbers = { 25, 35, 45, 89, 46, 86, 12, 496, 84, 61 };

            for(int i = 0; i<randomNumbers.Length; i++)
            {
                sum= sum+randomNumbers[i];
            }
           Console.WriteLine($"The sum of randomNumbersArray is {sum}");

               Console.WriteLine($"The average of randomNumbersArray is {sum/randomNumbers.Length}");

            //foreach(int num in randomNumbers)
            //{
            //    Console.WriteLine(num);
            //}

            Console.ReadLine();
        }
    }
}
