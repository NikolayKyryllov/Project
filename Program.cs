using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int M,S1=0,S2=0;
            Console.Write("Enter four-digit number: ");
            M = int.Parse(Console.ReadLine());
            int[] a=new int[4];
            for(int i=0;i<4;i++)
            {
                a[3-i] = M % 10;
                 M/=10;
            }

            for (int i = 0; i < 4; i++)
            {
                if (i < 2)
                {
                    S1 += a[i];
                }
                else
                    S2 += a[i];
            }
            if (S1 == S2)
                Console.WriteLine(true);
            else
                Console.WriteLine(false);

            Console.Read();
        }
    }
}
