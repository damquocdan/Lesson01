using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_3
{
    internal class Program
    {
        // Khai báo các biến
        static void Main(string[] args)
        {
            int id = 1;
            String name = "Đàm Quốc Dân";
            byte age = 18;
            char gender = 'M';
            // Khai báo hằng số
            const float percent = 75.50f;

            // hiển thị giá trị các biến và hằng số
            Console.WriteLine("Student ID :{0}",id);
            Console.WriteLine("Student name :{0}", name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Gender : " + gender);
            Console.WriteLine("Percentage: {0}",percent);
            Console.ReadKey();

        }
    }
}
