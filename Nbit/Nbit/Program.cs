using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nbit
{
    class Program
    {
        public static int n;
        public static int[] A;
        public static void tryBit(int i)
        {
            for (int j = 0; j <= 1; j++)
            {
                A[i] = j;
                if (i == n - 1)
                {
                    PrintSolution();
                }
                else
                    tryBit(i + 1);
            }
        }

        private static void PrintSolution()
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(A[i]);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        public static void Main(string[] args)
        {
            n = 4;
            A = new int[n];
            tryBit(0);
        }
    }
}
