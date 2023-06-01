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
           
            DateTime tt = new DateTime(); // создание объекта дата-время
            tt = System.DateTime.Now;
            Console.WriteLine(tt);

        }
    }
}
