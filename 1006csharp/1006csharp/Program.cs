using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1006csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string m;
            double A = 0;
            m = Console.ReadLine();
            A = Convert.ToDouble(m);
            double B = 0;
            m = Console.ReadLine();
            B = Convert.ToDouble(m);
            double C = 0;
            m = Console.ReadLine();
            C = Convert.ToDouble(m);
            double R = (((A * 2) + (B * 3) + (C * 5)) / 10);
            Console.WriteLine("MEDIA = " + R.ToString("0.0"));
            Console.ReadKey();
        }
    }
}
