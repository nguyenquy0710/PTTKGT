using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knapsack
{
    class Program
    {
        static private int[] chon, optChon;
        static private double[] kl, gt;
        static private double maxKL, optGT, tongGT, tongKL;
        static private int n;
        static void Knapsack(int x)
        {
            for (int j = 0; j <= 1; j++)
            {
                chon[x] = j;
                if (x == n - 1)
                {
                    tongGT = 0;
                    tongKL = 0;
                    for (int k = 0; k < n; k++)
                    {
                        tongGT += chon[k] * gt[k];
                        tongKL += chon[k] * kl[k];
                    }
                    if (maxKL >= tongKL && optGT < tongGT)
                    {
                        optGT = tongGT;
                        for (int l = 0; l < n; l++)
                            optChon[l] = chon[l];
                    }
                }
                else Knapsack(x + 1);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap so do vat: ");
            n = int.Parse(Console.ReadLine());
            chon = new int[n];
            optChon = new int[n];
            kl = new double[n];
            gt = new double[n];
            Console.Write("Nhap khoi luong toi da ma cai tui co the mang: ");
            maxKL = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap khoi luong va gia tri tung do vat");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Khoi luong cua do vat thu {0} la: ", i + 1);
                kl[i] = double.Parse(Console.ReadLine());
                Console.Write("Gia tri cua do vat thu {0} la: ", i + 1);
                gt[i] = double.Parse(Console.ReadLine());
            }
            Knapsack(0);
            Console.WriteLine("Tong gia tri lon nhat la: " + optGT);
            Console.Write("Nhung vat duoc chon la: ");
            for (int i = 0; i < n; i++)
                if (optChon[i] == 1) Console.Write((i + 1) + " ");
            Console.ReadKey();
        }
    }
}