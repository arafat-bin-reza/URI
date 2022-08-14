using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1001csharp
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
            int C = A + B;
            Console.Write("X = ");
            Console.WriteLine(C);
            Console.ReadKey();

        }
    }
}
