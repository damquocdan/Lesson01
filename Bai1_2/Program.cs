using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String MaNV;
            String HvT;
            String NS;
            String DC;
            String SDT;
            String Email;
            Console.Write("Nhập Mã nhân viên");
            MaNV = Console.ReadLine();
            Console.WriteLine("Nhập họ tên Nhân viên");
            HvT = Console.ReadLine();
            Console.WriteLine("Nhập Ngày sinh: ");
            NS = Console.ReadLine();
            Console.WriteLine("Nhập địa chỉ :");
            DC = Console.ReadLine();
            Console.WriteLine("Nhập số điện thoại");
            SDT = Console.ReadLine();
            Console.WriteLine("Nhập số email");
            Email = Console.ReadLine();
            Console.ReadKey();
         
        }
    }
}
