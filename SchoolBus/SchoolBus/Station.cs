using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBus
{
    class Station
    {
        private int id;
        private double viDo;
        private double kinhDo;
        private int soKhach;

        public void setID(int id)
        {
            this.id = id;
        }
        public int getID()
        {
            return this.id;
        }
        public void setSoKhach(int khach)
        {
            this.soKhach = khach;
        }
        public int getSoKhach()
        {
            return this.soKhach;
        }
        public void setViDo(double vd)
        {
            this.viDo = vd;
        }
        public double getViDo()
        {
            return this.viDo;
        }
        public void setKinhDo(double kd)
        {
            this.kinhDo = kd;
        }
        public double getKinhDo()
        {
            return this.kinhDo;
        }
        public Station() { }
        public Station(int id, double x, double y, int sl)
        {
            this.setID(id);
            this.setViDo(x);
            this.setKinhDo(y);
            this.setSoKhach(sl);
        }
    }
}
