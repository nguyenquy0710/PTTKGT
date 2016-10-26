using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoiTien
{
    class NguoiDung
    {
        private double soTien;
        public void setSoTien(double n)
        {
            if(n%10!=0)
            {
                Console.WriteLine("So tien phai chia het cho 10");
            }
            else
            {
                this.soTien = n;

            }
        }
        public double getSoTien()
        {
            return this.soTien;
        }
        public List<OutPut> Change(double n)
        {
            double temp = n;
            List<OutPut> ketQua = new List<OutPut>();
            if (temp > 0 && (temp / 100) != 0)
            {
                OutPut kq = new OutPut();
                kq.setMenhGia(100);
                kq.setSoLuong((long)temp / 100);
                ketQua.Add(kq);
                temp -= kq.getMenhGia() * kq.getSoLuong();
            }
            if (temp > 0 && (temp / 50) != 0)
            {
                OutPut kq = new OutPut();
                kq.setMenhGia(50);
                kq.setSoLuong((long)temp / 50);
                ketQua.Add(kq);
                temp -= kq.getMenhGia() * kq.getSoLuong();
            }
            if (temp > 0 && (temp / 20) != 0)
            {
                OutPut kq = new OutPut();
                kq.setMenhGia(20);
                kq.setSoLuong((long)temp / 20);
                ketQua.Add(kq);
                temp -= kq.getMenhGia() * kq.getSoLuong();
            }
            if (temp > 0 && (temp / 10) != 0)
            {
                OutPut kq = new OutPut();
                kq.setMenhGia(10);
                kq.setSoLuong((long)temp / 10);
                ketQua.Add(kq);
                temp -= kq.getMenhGia() * kq.getSoLuong();
            }
            return ketQua;
        }
    }
}
