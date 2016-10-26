using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoiTien
{
    class Program
    {
        static void Main(string[] args)
        {
            List<OutPut> list = new List<OutPut>();
            NguoiDung user = new NguoiDung();
            user.setSoTien(15463128410);

            Stopwatch st1 = new Stopwatch();
            st1.Start();
            //xem thoi gian ham chay la bao lau
            list = user.Change(user.getSoTien());
            st1.Stop();
            
            foreach (OutPut o in list)
            {
                Console.WriteLine("To tien " + o.getMenhGia() + "K bang " + o.getSoLuong());
            }
            Console.WriteLine("Thoi gian ham tinh tien chay: {0} Seconds", st1.Elapsed.ToString());
            Console.ReadLine();
        }
    }
}
