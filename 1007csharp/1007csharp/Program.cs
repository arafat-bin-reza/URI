using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1007csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string m;
            int A = 0;
            m = Console.ReadLine();
            A = Convert.ToInt32(m);
            int B = 0;
            m = Console.ReadLine();
            B = Convert.ToInt32(m);
            int C = 0;
            m = Console.ReadLine();
            C = Convert.ToInt32(m);
            int D = 0;
            m = Console.ReadLine();
            D = Convert.ToInt32(m);
            int R = (A*B)-(C*D);
            Console.Write("DIFERENCA = ");
            Console.WriteLine(R);
            Console.ReadKey();
        }
    }
}
