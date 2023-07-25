using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Biến / kiêu dữ liệu/ toán tử / toán hạng / biểu thức / câu lệnh / khối lệnh
            int x, y = 100;
            float a, b;
            char ch = 'Y';
            String name = "Đàm quốc Dân";
            var company = "devmaster Academy";
            bool Gender = true;

            // gán giá trị 
            x = 200;
            b = 123.12f;
            a = b * 2;
            // xuất ra màn hình 
            Console.Write("xin chào, " + name);
            Console.WriteLine("\n Company:"+company);
            Console.WriteLine("\n {0}+{1}={2}",x,y,x+y);
            Console.ReadKey();
          
        }
    }
}
