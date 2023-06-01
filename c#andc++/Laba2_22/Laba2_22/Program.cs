using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, M;

            do
            {
                Console.Write("Введите N (<= 15): ");
                N = int.Parse(Console.ReadLine());

            } while (N > 15 || N<1);

            do
            {
                Console.Write("Введите M (<= 10): ");
                M = int.Parse(Console.ReadLine());

            } while (M > 10 || M < 1);


            int[,] A = new int[N, M];
            int []B = new int[N];
            Random rnd = new Random();
            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                {
                    A[i, j] = rnd.Next(100);
                    //Console.WriteLine("Введите элемент {0} {1}", i, j);

                    //A[i, j] = int.Parse(Console.ReadLine());
                }


            Console.WriteLine("\n\nВаша матрица");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(A[i, j] + " " + '\t');
                }
                Console.WriteLine();
            }




            for (int i = 0; i < N; i++)
            {
                B[i] = A[i, 0];
                for (int j = 1; j < M; j++)
                {
                    if (B[i]>A[i,j])
                    {
                        B[i] = A[i, j];
                    }
                }
            }


            Console.WriteLine("Ваш массив минимальныйх элемеентов каждой строки");
            foreach (int item in B)
            {
                Console.Write(item + " ");
            }



            Console.Read();
        }
    }
}
