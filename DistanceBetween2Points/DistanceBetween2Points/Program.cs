using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetween2Points
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2, kc;
            Console.WriteLine("Nhap toa do diem A: ");
            Console.Write("x = ");
            x1 = double.Parse(Console.ReadLine());
            Console.Write("y = ");
            y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("=> A({0};{1})", x1, y1);
            Console.WriteLine("Nhap toa do diem B: ");
            Console.Write("x = ");
            x2 = double.Parse(Console.ReadLine());
            Console.Write("y = ");
            y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("=> B({0};{1})", x2, y2);

            kc = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Khoang cach giua hai diem la {0}", kc);
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
