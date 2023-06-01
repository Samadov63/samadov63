using System;
using System.Globalization;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int a;
            Console.WriteLine("Введите свой годовой доход");
            a = int.Parse(Console.ReadLine());

            if (a <= 20000)
            {
                Console.WriteLine("Результат с учётом налога = " + ((a * 0.12) + a));
                Console.WriteLine("Сумма налога = " + a * 0.12);
            }
            if(a > 20000 & a <= 40000)
            {
                Console.WriteLine("Результат с учётом налога = " + ((a * 0.2) + a));
                Console.WriteLine("Сумма налога = " + a * 0.2);
            }
            if(a > 40000)
            {
                Console.WriteLine("Результат с учётом налога = " + ((a * 0.3) + a));
                Console.WriteLine("Сумма налога = " + a * 0.3);
            }
            else
            {
                Console.WriteLine("123");
            }

        }
    }
}
