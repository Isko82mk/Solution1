using System;

namespace oddEvenArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            int[] oddEvenArray = { 10, 23, 44, 123, 55, 52, 98, 99, 102, 103, 152, 49 };

            int j = 0;
            int k = 0;

            int[] eavenArray = new int[6];
            int[] oddArray = new int[6];


            for (int i=0; i<oddEvenArray.Length; i++)
            {
                if (oddEvenArray[i]%2 == 0)
                {
                    eavenArray[j] = oddEvenArray[i];
                    j++;
                }
                else
                {
                    oddArray[k] = oddEvenArray[i];
                    k++;
                }
            }

            Console.WriteLine("Eaven numbers :");
            foreach (int eaven in eavenArray)
            {
                Console.WriteLine(eaven);
            }

            Console.WriteLine("Odd numbers :");
            foreach (int odd in oddArray)
            {
                Console.WriteLine(odd);
            }


            Console.ReadLine();
        }
    }
}
