using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите количество элемнов: \t");
            int elCount = int.Parse(Console.ReadLine());
            int[] myList = new int[elCount];

            for (int i = 0; i < myList.Length; i++)
            {
                myList[i] = int.Parse(Console.ReadLine());
            }
         
           Console.WriteLine("Вывод масиива: ");

            for (int i = 0; i < myList.Length; i++)
            {
                Console.WriteLine(myList[i]);
            }

            Console.ReadLine();
        }
    }
}

