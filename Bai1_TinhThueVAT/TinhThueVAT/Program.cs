using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Casting_Operator
{
    internal class Program
    {
        //Đề bài 1
        //khai báo hằng số VAT
        const double VAT = 0.1;

        //Hàm nhập thông tin đơn giá và số lượng
        static void NhapDonGiaVaSoLuong(out double donGia, out int soLuong)
        {
            
            Console.WriteLine("Nhap don gia: ");
            donGia=  double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so luong: ");
            soLuong = int.Parse(Console.ReadLine());

        }

        //Hàm tính tiền
        static void TinhTien(double donGia, int soLuong, out double thanhTien, out double thueVAT, out double tongTien)
        {
            thanhTien = donGia * soLuong;
            thueVAT = thanhTien * VAT;
            tongTien = thanhTien + thueVAT;
        }

        // Hàm tăng số lượng lên 1 (ref)
        static void TangSoLuong(ref int soLuong)
        {
            soLuong++;
        }
        static void Main(string[] args)
        {
            double donGia;
            int soLuong;
            NhapDonGiaVaSoLuong(out donGia, out soLuong);

            double thanhTien, thueVAT, tongTien;
            TinhTien(donGia, soLuong, out thanhTien, out thueVAT, out tongTien);

            int tongTienInt = Convert.ToInt32(tongTien);

            Console.WriteLine("Tong tien la: "+tongTienInt);


            
        }
    }
}
