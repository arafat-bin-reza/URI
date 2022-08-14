using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1002csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string m;
            double A; 
            double R;
            
            m = Console.ReadLine();
            R = Convert.ToDouble(m);            
            A = 3.14159 * (R * R);
            Console.WriteLine("A=" + A.ToString("0.0000"));
            Console.ReadKey(); 
        }
    }
}
