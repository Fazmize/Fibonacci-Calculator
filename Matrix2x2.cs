
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Fibonacci
{
    internal class Matrix2x2
    {
        //  |Cell_A, Cell_B|
        //  |Cell_C, Cell_D|
        public BigInteger Cell_A {get; set;}
        public BigInteger Cell_B {get; set;}
        public BigInteger Cell_C {get; set;}
        public BigInteger Cell_D {get; set;}

        public Matrix2x2(BigInteger Cell_A, BigInteger Cell_B, BigInteger Cell_C, BigInteger Cell_D)
        {
            this.Cell_A = Cell_A;
            this.Cell_B = Cell_B;
            this.Cell_C = Cell_C;
            this.Cell_D = Cell_D;
        }

        public static Matrix2x2 MatrixMultiply(Matrix2x2 MatrixA, Matrix2x2 MatrixB)
        {
            Matrix2x2 result = new(0,0,0,0);

            result.Cell_A = (MatrixA.Cell_A * MatrixB.Cell_A) + (MatrixA.Cell_B * MatrixB.Cell_C);
            result.Cell_B = (MatrixA.Cell_A * MatrixB.Cell_B) + (MatrixA.Cell_B * MatrixB.Cell_D);
            result.Cell_C = (MatrixA.Cell_C * MatrixB.Cell_A) + (MatrixA.Cell_D * MatrixB.Cell_C);
            result.Cell_D = (MatrixA.Cell_C * MatrixB.Cell_B) + (MatrixA.Cell_D * MatrixB.Cell_D);
            return result;
        }

        public string ShowMatrix()
        {
            return $"|{Cell_A}, {Cell_B}|\n|{Cell_C}, {Cell_D}|";
        }

    }
}
