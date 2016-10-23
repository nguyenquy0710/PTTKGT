using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBus
{
    class Buses
    {
        private int stt;
        private int kichCo;

        public void setSTT(int stt)
        {
            this.stt = stt;
        }
        public int getSTT()
        {
            return this.stt;
        }
        public void setKichCo(int kc)
        {
            this.kichCo = kc;
        }
        public int getKichCo()
        {
            return this.kichCo;
        }
        public Buses()
        {

        }
        public Buses(int stt, int kichCo)
        {
            this.setSTT(stt);
            this.setKichCo(kichCo);
        }
    }
}
