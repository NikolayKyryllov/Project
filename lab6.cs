//Створити ліст інтових значень 0-9, дозволити введення з клавіатури.
//Порахувати кількість входження кожного числа в ліст. Створити масив, в
//якому індекс буде відповідати числу, а кількість входження цього числа –
//змінній на цьому індексі.
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
            Random rand = new Random();
            int N, b,j;
            Console.Write("Enter size of the list: ");
            N = int.Parse(Console.ReadLine());
            List<int> values = new List<int>(N);
            int[] arr = new int[N];
            int[] brr = new int[N];
            for(int i=0;i<N;i++)
            {
                b = rand.Next(0, 9);
                values.Add(b);
            }
            for (int i = 0; i < N; i++)
            {
                arr[i] = 0;
             for(int j=0;j<N;j++)
                {
                    if(i!=j)
                    {
                        if(values[i]==values[j])
                        {
                            arr[i]++;
                        }
                    }
                }
            }
            for(int i=0;i<N;i++)
            {
                j = values[i];
                brr[j] = arr[i];
            }
            for (int i=0;i<N;i++)
            {
                Console.Write($"{values[i]}\t");
            }
            Console.WriteLine();
            for (int i = 0; i < N; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
            Console.Read();
        }
    }
}
