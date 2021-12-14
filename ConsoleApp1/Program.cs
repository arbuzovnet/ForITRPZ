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
            Random random = new Random();
            int temp = random.Next(0, 2);
            if (temp == 0)
                Console.WriteLine("temp == 0");
            else
                Console.WriteLine("temp != 0");
            Console.ReadKey();
        }
    }
}
