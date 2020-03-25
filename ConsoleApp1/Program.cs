using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {




            int[] numbers = new int[3];
            int sum = 0;

            Console.WriteLine("Input three numbers");

            for (int i =0; i<numbers.Length; i++)
            {
                
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }


           foreach( int num in numbers)
              
            {
               Console.WriteLine($" {num}");
            }


            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine($"vkupnp :{sum}");
            Console.WriteLine($"prosek :{sum/numbers.Length}");










            Console.ReadLine();
        }
    }
}
