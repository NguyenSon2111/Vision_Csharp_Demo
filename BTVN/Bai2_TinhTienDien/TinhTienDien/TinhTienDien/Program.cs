using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhTienDien
{
    internal class Program
    {
        //Khai báo hằng số
        const double WH_TO_KWH = 1000;
        const double PRICE_PER_KWH = 2500;
        static double TinhTienDien (ref int soDien_Wh)
        {
            //ép kiểu và quy đổi từ kWh sang Wh
            int soDien_KWh = Convert.ToInt32(soDien_Wh/ WH_TO_KWH);
            //tính tiền điện
            double tienDien = PRICE_PER_KWH * soDien_KWh;

            //ghi đè lên số điện WH ban đầu
            soDien_Wh= soDien_KWh;
            return tienDien;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so dien tieu thu (Wh): ");
            int soDien_Wh = int.Parse(Console.ReadLine());
            double tienDien = TinhTienDien(ref soDien_Wh);

            Console.WriteLine("so dien tieu thu (KWh): " + soDien_Wh);
            Console.WriteLine("Tien dien: " + tienDien + "VND");
        }
    }
}
