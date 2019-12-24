//10. Дана матриця цілих чисел розміру M x N. Різні рядки (стовпчики)
//матриці назвемо схожими, якщо співпадає множина чисел, що
//зустрічаються в цих рядках (стовпчиках). Знайти кількість рядків
//(стовпчиків), схожих на 1) перший; 2) останній рядок (стовпчик).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laab5
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N, k, t = 0, G,Selection,p;
            Console.Write("Selection: ");
            Selection = int.Parse(Console.ReadLine());
            Console.Write("M: ");
            M = int.Parse(Console.ReadLine());
            Console.Write("N: ");
            N = int.Parse(Console.ReadLine());
            int[,] a = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {                                                              // 1 2 3
                    a[i, j] = int.Parse(Console.ReadLine());                   // 1 2 3   
                }                                                              // 1 2 3
            }
            switch(Selection)
                {
                case 1:
                    {
                        G = M;
                        p = 0;
                        for (int i = 0; i < M; i++)
                        {
                            k = 0;
                            if (i == M - 1)
                            {
                                break;
                            }
                            for (int j = 0; j < N; j++)
                            {
                                for (int k1 = 1; k1 < G; k1++)
                                {
                                    if (a[i, j] == a[i + k1, j])
                                    {
                                        k++;
                                        t = k1;
                                        break;
                                    }
                                }
                                if(i==0 && k==N)
                                {
                                    p++;
                                }
                                if (k == N)
                                {
                                    Console.WriteLine($"row{i} and row{i + t} are similar");
                                }
                            }
                            if (i == 0 && k == N)
                                Console.WriteLine($"Amount rows that are similar on first row: {p}");
                            G--;
                        }
                        break;
                    }
                case 2:
                    {
                        G = N;
                        p = 0;
                        for (int j = 0; j < N; j++)
                        {
                            k = 0;
                            if (j == N - 1)
                            {
                                break;
                            }
                            for (int i = 0; i < M; i++)
                            {
                                for (int k1 = 1; k1 < G; k1++)
                                {
                                    if (a[i, j] == a[i , j+k1])
                                    {
                                        k++;
                                        t = k1;
                                        break;
                                    }
                                }
                                if (j == 0 && k == M)
                                {
                                    p++;
                                }
                                if (k == M)
                                {
                                    Console.WriteLine($"column{j} and column{j + t} are similar");
                                }
                            }
                            if (j == 0 && k == M)
                                Console.WriteLine($"Amount columns that are similar on first column: {p}");
                            G--;
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
