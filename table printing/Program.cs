using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace table_printing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number which table you want");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i<= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", num, i, num * i);
            }
        }
    }
}
