using System;

namespace arrayWithDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {

           
            int[] arrWithDup = { 1, 4, 6, 3, 4, 5, 9, 3, 2, 9 };
         
            for (int i =0; i< arrWithDup.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < arrWithDup.Length; j++)
                {
                    if (arrWithDup[i] == arrWithDup[j])
                        count = count +1;
                    
                }


                Console.WriteLine($"Number{arrWithDup[i]} ocures {count} time.");

              
            }


            Console.ReadLine();
        }
    }
}
