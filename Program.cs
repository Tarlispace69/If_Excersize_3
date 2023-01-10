using System;

namespace If_Excersize_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring variables
            int input1;

            //recieving input
            Console.Write("Please enter a number: ");
            input1 = int.Parse(Console.ReadLine());

            //checking if input is positive and even
            if (input1 > 0 && input1 % 2 == 0)
            {
                Console.WriteLine($"The square of the input is: {input1 * input1}");
            }
        }
    }
}
