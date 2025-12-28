using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhTienLuong
{
    internal class Program
    {
        //khai báo hằng số
        const int MIN_PER_HOUR = 60;
        const int SALARY_PER_HOUR = 45000;
        //Hàm ref tính tiền lương
        static double TinhTienLuong (ref int mins)
        {
            double hours = (double)mins / MIN_PER_HOUR;
            mins = Convert.ToInt32(hours);
            double tienLuong = mins * SALARY_PER_HOUR;
            return tienLuong;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Tong so phut lam viec: ");
            int mins = Convert.ToInt32(Console.ReadLine());
            double tienLuong = TinhTienLuong(ref mins);

            Console.WriteLine("So gio lam viec: " + mins + "h");
            Console.WriteLine("Tong tien luong la: " + tienLuong + "VND");



        }
    }
}
