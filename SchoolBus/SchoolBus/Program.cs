using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBus
{
    class Program
    {
        static void Main(string[] args)
        {
            InputData f = new InputData();
            List<Distance> distance = new List<Distance>();
            List<Buses> buses = new List<Buses>();
            List<Station> station = new List<Station>();
            distance = f.InputDistance(@"D:\BaiTap\MicrosoftVisualStudio\Starting\SchoolBus\SchoolBus\input\distance.txt");
            buses = f.InputBuses(@"D:\BaiTap\MicrosoftVisualStudio\Starting\SchoolBus\SchoolBus\input\buses.txt");
            station = f.InputStation(@"D:\BaiTap\MicrosoftVisualStudio\Starting\SchoolBus\SchoolBus\input\station.txt");
            Console.WriteLine("--------------Distance-------------");
            foreach (Distance d in distance)
            {
                Console.WriteLine(d.getKhoangCach() + " \t " + d.getThoiGian());
            }
            Console.WriteLine();
            Console.WriteLine("--------------Buses-------------");
            foreach (Buses b in buses)
            {
                Console.WriteLine(b.getSTT() + "\t" + b.getKichCo());
            }
            Console.WriteLine();
            Console.WriteLine("--------------Station-------------");
            foreach (Station s in station)
            {
                Console.WriteLine(s.getID() + "\t" + s.getViDo() + "\t" + s.getKinhDo() + "\t" + s.getSoKhach());
            }
        }
    }
}
