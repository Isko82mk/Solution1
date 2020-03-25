using System;


namespace Find_maximum_and_minimum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 25, 35, 45, 89, 46, 86, 12, 496, 84, 61 };


            int min = numbers[0];
            int max = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                else if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            Console.WriteLine($"MAX elemeni is {max}");
            Console.WriteLine($"MIN elemeni is {min}");

            int maxIndex = Array.IndexOf(numbers, max);
            int minIndex = Array.IndexOf(numbers, min);

            Console.WriteLine($" Index for max number is {maxIndex}");
            Console.WriteLine($" INdex for min number is  {minIndex}");


            Console.ReadKey();
        }
    }
}


