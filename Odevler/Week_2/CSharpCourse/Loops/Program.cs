using System.Net.WebSockets;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //WhileLoop();
            //DoWhileLoop();
            //ForEachLoop();
            if (IsPrimeNumber(91)) 
            {
                Console.WriteLine("This is a prime number.");
            }
            else
            {
                Console.WriteLine("This is not a prime number.");
            }

        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if (number%i==0)
                {
                    result = false;
                    i = number;
                }
            }
            return result;
        }
        private static void ForEachLoop()
        {
            string[] students = new string[3] { "Orhun", "Furkan", "Jacquie" };
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
        }

        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 11);
        }

        private static int WhileLoop()
        {
            int number = 15;
            while (number <= 100)
            {
                Console.WriteLine(number);
                number = number + 10;
            }
            Console.WriteLine("Now number is {0}", number);
            return number;
        }

        private static void ForLoop()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
