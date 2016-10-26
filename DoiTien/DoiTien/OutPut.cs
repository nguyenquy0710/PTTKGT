using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoiTien
{
    class OutPut
    {
        private double menhGia;
        private long soLuong;
        public void setMenhGia(double n)
        {
            this.menhGia = n;
        }
        public double getMenhGia()
        {
            return this.menhGia;
        }
        public void setSoLuong(long n)
        {
            this.soLuong = n;
        }
        public long getSoLuong()
        {
            return this.soLuong;
        }
    }
}
