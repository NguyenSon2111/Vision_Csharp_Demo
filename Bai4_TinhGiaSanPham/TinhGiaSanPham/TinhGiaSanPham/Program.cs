using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhGiaSanPham
{
    internal class Program
    {
        const double VAT = 0.1;
        static double TinhGiaSanPham (ref double giaGoc)
        {
            double thueVAT = giaGoc * VAT;
            double giaSauThue = giaGoc + thueVAT;
            int giaSauThue_Int = (int)giaSauThue;
            giaGoc = giaSauThue_Int;
            return giaSauThue;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap gia goc san pham: ");
            double giaGoc= Convert.ToDouble(Console.ReadLine());
            double giaSauThue = TinhGiaSanPham(ref giaGoc);
            Console.WriteLine("Gia san pham sau thue la: " + giaSauThue + "VND");
            Console.WriteLine("Gia sau thue da lam tron: " + giaGoc + "VND");
        }
    }
}
