using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBus
{
    class Distance
    {
        private int khoangCach;
        private int thoiGian;

        public void setKhoangCach(int kc)
        {
            this.khoangCach = kc;
        }
        public int getKhoangCach()
        {
            return this.khoangCach;
        }
        public void setThoiGian(int tg)
        {
            this.thoiGian = tg;
        }
        public int getThoiGian()
        {
            return this.thoiGian;
        }
        public Distance()
        {
        }
        public Distance(int kc, int tg)
        {
            this.setKhoangCach(kc);
            this.setThoiGian(tg);
        }
    }
}
