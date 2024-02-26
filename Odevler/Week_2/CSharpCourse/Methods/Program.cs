namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //var result = Add2(3,5);
            //Console.WriteLine(result);
            //Add22(50);

            //var multiply = Multiply(2, 15);
            //var multiply2 = Multiply(2, 15,3);
            //Console.WriteLine(multiply);
            //Console.WriteLine(multiply2);

            Console.WriteLine(Add4(3,5,7,9,10));
        }

        static void Add()
        {
            Console.WriteLine("Added.");
        }

        static int Add2(int number1, int number2)
        {
            var result = number1 + number2;
            return result;
        }

        static void Add22(int number0,int number1 = 15, int number2= 20)
        {
            Console.WriteLine("number0 is: " + number0 + "number1 is: " + number1+ "number2 is: " + number2);
        }

        static int Multiply(int number1, int number2)
        {
            var result = number1 * number2;
            return (int)result;
        }
        static int Multiply(int number1, int number2,int number3)
        {
            var result = number1 * number2 * number3;
            return (int)result;
        }
        static int Add4(int number, params int[] numbers)
        {
            return numbers.Sum();
        }


    }
}
