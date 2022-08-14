using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1005csharp
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
            double C = (((A*3.5) + (B*7.5))/11);
            Console.WriteLine("MEDIA = " + C.ToString("0.00000"));
            Console.ReadKey();
        }
    }
}
