using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rabota2_1
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Введите размерность двумерного массива: ");
            Console.Write("Строк: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 1 || n > 15)
            {
                Console.WriteLine("n вне диапазона");
                Console.ReadKey();
                return;
                
            }
            Console.Write("Столбцов: ");
            int m = Convert.ToInt32(Console.ReadLine());
            if (m < 1 || m > 10)
            {
                Console.WriteLine("m вне диапазона");
                Console.ReadKey();
                return;
                
            }
            
            int[,] array = new int[n, m];

            int[] minArray = new int[n];
            Random rnd = new Random();
            int index = 0;
            
           
            for (int i = 0; i < n; i++)
            {
                
                int min = 0;
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = rnd.Next(15);
           
                    if (j == 0) min = array[i, j];
                    else if (array[i, j] < min) min = array[i, j];
                  // Console.Write(array[i, j] + "\t");

                }
                minArray[i] = min;
                Console.WriteLine();
            }

           

            
            foreach (int a in array)
            {
                Console.Write($"{a}\t");
                index++;
                if (index == array.GetLength(0))
                {
                    Console.WriteLine();
                    index = 0;
                }
            }



            Console.WriteLine("\nМинимальное значение");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                int minLine = array[i, 0];
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    if (array[i, j] < minLine)
                    {
                        minLine = array[i, j];

                    }
                }



                Console.WriteLine("Строка{0}, значение: {1}", i, minLine);
                Console.WriteLine();
            }
            Console.ReadKey();

            /*
            Console.WriteLine("массив минимальных элементов: ");
            for (int i = 0; i < n; i++)
            {
                  Console.Write("Min element = " + minArray[i] + "\n");
                //Console.Write("Строка{0}, значение: {1}", minArray[i]);
            }
            */

           

        }
    }
}
