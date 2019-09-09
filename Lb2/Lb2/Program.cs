using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k, L;
            double R = 0;
            do
            {
                Console.Write("enter index n= ");
                n = int.Parse(Console.ReadLine());
                k = n * n;
            } while (n*k<n*n && n*k<0);
            L = n * k;
            double[] a = new double[L];
            for(int i=1;i<L;i++)
            {
                a[i] = Math.Pow(-1, i * i + i + 1) * Math.Pow(i, 2)/((2*Math.Pow(i, 2))+5);
            }
            for(int i=1;i<=L;i++)
            {
                if(i==n*n)
                {
                    R = a[i];
                    for (int j=n*n+1; j < L; j++)
                    {
                        R=R*a[j];
                    }
                }
            }
            Console.WriteLine($"R={R}");
            Console.Read();
        }
    }
}
