using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delete
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
                arr[i] = rnd.Next(100);
            foreach (int y in arr)
                Console.Write("{0} ", y);
            int Min = arr[0], Max = arr[0];
            foreach (int x in arr)
            {
                if (x > Max)
                    Max = x;
                else if (x < Min)
                    Min = x;
            }
            Console.WriteLine("\nMin= {0} Max= {1}", Min, Max);
            Console.ReadLine();
        }
    }
}
