using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square
{
    class Program
    {
        static void Main(string[] args)
        {

            int i, sum=0, SumSquare=0, diff;
            for(i=1; i<=100; i++)
            {
                sum = sum + i;
                SumSquare = SumSquare + (i * i);
            }
            sum = sum * sum;
            Console.WriteLine("Sum Square of the first 100 number is: " + sum);
            Console.WriteLine("Sum of the first 100 number Square is: " + SumSquare);
            diff = sum - SumSquare;
            Console.WriteLine("The Difference of Sum Square and Square of 100 number sum is: " + diff);

            Console.ReadKey();

            
        }
    }
}
