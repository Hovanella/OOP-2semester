using System;
using System.Text;
using System.Xml.Schema;

namespace ConsoleApplication1
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var a = new double[,] { { 3, -1, 2 }, { 4, 2, 0 }, { -5, 6, 1 } };
            var b = new double[,] { { 8, 1 }, { 7, 2 }, { 2, -3 } };
            var c = new double[3, 2];

            for (var i = 0; i < a.GetLength(0); i++)
            {
                for (var j = 0; j < b.GetLength(1); j++)
                {
                    c[i, j] = 0;

                    for (var k = 0; k < a.GetLength(1); k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }
            }

            for (var i = 0; i <3; i++)
            {
                for (var i1 = 0; i1 < 2; i1++)
                {
                    Console.Write(c[i, i1]+" ");
                }

                Console.WriteLine();
            }

        }
    }

}