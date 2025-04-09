
using System.Numerics;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fibonacci(1476) is the biggest calculable argument
            
            BigInteger bigInteger = new(GetFibonacci(1476));
            Console.WriteLine(bigInteger);
        }

        public static double GetFibonacci(int fibonacciNumber)
        {
            Matrix2x2 fibMatrix = new(1, 1, 1, 0);
            Matrix2x2 result = new(1, 1, 1, 0);
            if(fibonacciNumber == 1 ||  fibonacciNumber == 2)
            {
                return 1;
            }
            for(int i = 0; i < fibonacciNumber - 2; i++)
            {
                result = Matrix2x2.MatrixMultiply(result, fibMatrix);
            }
            return result.a;
            
         }

        public static void ShowFibonacci(int fibNumber)
        {
            string FibResult = $"Fibonacci of {fibNumber} = ";
            Console.WriteLine(FibResult + GetFibonacci(fibNumber).ToString());
        }
    }


}
