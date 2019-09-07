using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb1
{
    class Program
    {
        static void Main(string[] args)
        {
            double v, t, h;
            Console.Write("enter starting speed: ");
            v = double.Parse(Console.ReadLine());
            Console.Write("enter height: ");
            h = double.Parse(Console.ReadLine());
            t = 2 * h / v;
            Console.WriteLine($"t={t}");
            Console.ReadKey();
        }
    }
}
