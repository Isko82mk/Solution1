using System;

namespace user_to_enter_a_username
{
    class Program
    {
        static void Main(string[] args)
        {
           


            string[] userNames = { "user1", "user2", "user3"  };
            string[] passwords = { "first", "second", "third" };


            Console.WriteLine("Please enter username!");

            string userName = Console.ReadLine();
            Console.WriteLine("Please enter password!");

            string password = Console.ReadLine();

            if (userNames[0] == userName || passwords[0] == password || userNames[1] == userName || passwords[1] == password || userNames[2] == userName || passwords[2] == password)
            {
                Console.WriteLine("You are logged in successfully");
            }
            else Console.WriteLine("Incorrect username or password");



            Console.ReadLine();
        }
    }
}
