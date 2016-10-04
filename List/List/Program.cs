using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            Element<int> a = new Element<int>(2);
            Element<int> b = new Element<int>(3);
            Element<int> c = new Element<int>(5);
            List<int> ds = new List<int>();
            ds.themDau(a);
            ds.themDau(b);
            ds.themDau(c);
            ds.printList();
            Console.WriteLine();
            List<string> ds1 = new List<string>();
            ds1.themDau(new Element<string>("thanh"));
            ds1.themDau(new Element<string>("nam"));
            ds1.themDau(new Element<string>("dao"));
            ds1.themDau(new Element<string>("tung"));
            ds1.printList();
            Console.ReadKey();
        }
    }
}
