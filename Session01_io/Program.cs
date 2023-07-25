using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01_io
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String a = "39";
            String b = "21";
            Console.WriteLine(a+b);
            int x = Convert.ToInt32(a);
            int y = Convert.ToInt32(b);
            Console.WriteLine(x+y);
            x= int .Parse(a);
            y= int .Parse(b);
            Console.WriteLine(x + y);

            // Nhập 
            Console.Write("Nhập x");
            x = int .Parse(Console.ReadLine());
            Console.Write("Nhập y");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}+{1}={2}",x,y,x+y);

            double m = 123.12;
            Console.WriteLine(m);
            x = Convert.ToInt32 (m);
            Console.WriteLine(x);
            m = y;
            Console.WriteLine(m);

        }
    }
}
