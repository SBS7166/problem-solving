using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, sum =0;
            for(i=1; i<1000; i++)
            {
                if(i%3==0 || i % 5 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("Sum of Multiples of 3 or 5 below 1000 is: " + sum);
            Console.ReadKey();
        }
    }
}
