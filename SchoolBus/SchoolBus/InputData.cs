using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBus
{
    class InputData
    {
        public List<Distance> InputDistance(string path)
        {
            List<Distance> ds = new List<Distance>();
            //DocFile fle 
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] temp = line.Split('\t');
                    int kc, tg;
                    if (int.TryParse(temp[0], out kc) && int.TryParse(temp[1], out tg))
                    {
                        Distance dis = new Distance(kc, tg);
                        ds.Add(dis);
                    }
                }
            }
            return ds;
        }
        public List<Buses> InputBuses(string path)
        {
            List<Buses> ds = new List<Buses>();
            //DocFile fle 
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] temp = line.Split('\t');
                    int stt, kc;
                    if (int.TryParse(temp[0], out stt) && int.TryParse(temp[1], out kc))
                    {
                        Buses bus = new Buses(stt, kc);
                        ds.Add(bus);
                    }
                }
            }
            return ds;
        }
        public List<Station> InputStation(string path)
        {
            List<Station> ds = new List<Station>();
            //DocFile fle 
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] temp = line.Split('\t');
                    int id, sl;
                    double x, y;
                    if (int.TryParse(temp[0], out id) && int.TryParse(temp[3], out sl) && double.TryParse(temp[1], out x) && double.TryParse(temp[2], out y))
                    {
                        Station sta = new Station(id, x, y, sl);
                        ds.Add(sta);
                    }

                    //foreach(string s in temp)
                    //{
                    //    Console.WriteLine(s);
                    //}
                }
            }
            return ds;
        }
    }
}
