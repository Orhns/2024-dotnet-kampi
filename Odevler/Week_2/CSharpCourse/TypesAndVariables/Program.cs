using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            double number5 = 21.44;
            decimal number6 = 21.5m;
            string city = "Ankara";
            char character = 'A';
            bool condition = true;
            int number1 = -10;
            long number2 = 4544554949494949555;
            short number3 = 5455;
            byte number4 = 255;
            //var number7 = 10;

            Console.WriteLine((int)Days.Friday);
            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Character is : {0}", (int)character);




            Console.ReadLine();
        }
        enum Days
        {
            Monday=10,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
        }
    }
}
