using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpperLower
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, i;
            Console.WriteLine("Please Enter The Upper Limit: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter The Lower Limit: ");
            m = Convert.ToInt32(Console.ReadLine());
            if (m > n)
            {
                Console.WriteLine("Wrong Input");
            }
            else
            {
                for(i=m; i<=n; i++)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
