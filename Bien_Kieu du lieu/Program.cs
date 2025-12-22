using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bien_Kieu_du_lieu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            //kiểu dữ liệu giá trị
            char b = 'b';
            Console.WriteLine("char: " +b );

            int i = 2000;
            Console.WriteLine("int: " + i);

            short s = 68;
            Console.WriteLine("short: " + s);

            long l = 10000000000;
            Console.WriteLine("long: " + l);

            uint ui = 98;
            Console.WriteLine("uint: " + ui);

            ushort us = 123;
            Console.WriteLine("ushort: " + us);

            ulong ul = 234567;
            Console.WriteLine("ulong: " + ul);

            float f = 3.2f;
            Console.WriteLine("float: " + f);

            double d = 4.151617;
            Console.WriteLine("double: "+ d);

            decimal dec = 389.5m;
            Console.WriteLine("decimal: "+ dec);

            Console.WriteLine("---------------------------------------");

            //boxing và unboxing

            //boxing: chuyển value type thành object
            int a=10;
            object obj = a;
            Console.WriteLine(obj);
            Console.WriteLine(obj.GetType());

            //unboxing: chuyển object và value type
            int obj2=(int)obj;
            Console.WriteLine(obj2);

            Console.WriteLine("---------------------------------------");

            //dùng decimal tính thuế VAT
            decimal value = 10.5m;
            decimal VAT = 0.08m;
            decimal totalPrice = value*VAT+value;
            Console.WriteLine(totalPrice);







        }
    }
}
