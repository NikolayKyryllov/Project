//Даний масив розміру N і число k до (0 &lt; k &lt; N). Здійснити циклічне
//зсув елементів масиву ліворуч (праворуч) на k позицій.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
           int r;
            int N, k;
            float[] a ;
                Console.Write("enter r: ");
                r = int.Parse(Console.ReadLine());
            Console.Write("enter size array: ");
            N = int.Parse(Console.ReadLine());
            do
            {
                Console.Write("enter k: ");
                k = int.Parse(Console.ReadLine());
            } while (k <= 0 || k >= N);
            switch (r)
            {
                case 0:
                    {
                        
                        a = new float[N];
                        for (int i = 0; i < N; i++)
                        {
                            a[i] = float.Parse(Console.ReadLine());

                        }
                        Array.Resize(ref a, N + k);
                        int j = 0;
                        for(int i=N;i<a.Length;i++)
                        {
                            a[i] = a[j];
                            j++;
                        }
                        for (int i = 0; i < a.Length; i++)
                        {
                            Console.Write($"{a[i]}\t");
                        }
                        break;
                    }
                case 1:
                    {
                        a = new float[N+k];
                        for (int i = k; i < N+k; i++)
                        {
                            a[i] = float.Parse(Console.ReadLine());

                        }
                        Array.Resize(ref a, N + k);
                        int j = 0;
                        for (int i = k; i < a.Length-1; i++)
                        {
                            a[j]=a[i];
                            j++;
                        }
                        for (int i = 0; i < a.Length; i++)
                        {
                            Console.Write($"{a[i]}\t");
                        }
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            Console.Read();
        }
    }
}