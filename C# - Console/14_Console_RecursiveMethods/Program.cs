using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Console_RecursiveMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            // Recursive Methods
            // Özyinelemeli metotlar

            int result = Factorial(5);

            string input = Console.ReadLine();

            int number = int.Parse(input);

            int fibo = Fibonacci(number);
            Console.WriteLine(fibo);

            Console.ReadLine();
        }

        static int Fibonacci(int step)
        {
            if (step == 0 || step == 1)
                return step;

            return Fibonacci(step - 1) + Fibonacci(step - 2);
        }

        static int Factorial(int number)
        {
            if (number == 0)
                return 1;

            return number * Factorial(number - 1);
        }


        //static int Factorial(int number)
        //{
        //    int result = 1;

        //    while (number > 1)
        //    {
        //        result = result * number;

        //        number--;
        //    }

        //    return result;
        //}

        static void DoSomething()
        {
            DoSomething();
        }
    }
}
