
using System.Runtime.CompilerServices;

namespace Fibonacci
{
    internal class Matrix2x2
    {
        //  |a, b|
        //  |c, d|
        public double a {get; set;}
        public double b {get; set;}
        public double c {get; set;}
        public double d {get; set;}

        public Matrix2x2(double a, double b, double c, double d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public static Matrix2x2 MatrixMultiply(Matrix2x2 MatrixA, Matrix2x2 MatrixB)
        {
            Matrix2x2 result = new(0,0,0,0);

            result.a = (MatrixA.a * MatrixB.a) + (MatrixA.b * MatrixB.c);
            result.b = (MatrixA.a * MatrixB.b) + (MatrixA.b * MatrixB.d);
            result.c = (MatrixA.c * MatrixB.a) + (MatrixA.d * MatrixB.c);
            result.d = (MatrixA.c * MatrixB.b) + (MatrixA.d * MatrixB.d);
            return result;
        }

        public string ShowMatrix()
        {
            return $"|{a}, {b}|\n|{c}, {d}|";
        }

    }
}
