using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAvg
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, Average;
            Console.WriteLine("Enter the number of Elements: ");
            n = Convert.ToInt32(Console.ReadLine());
            int [] numberList = new int[n];

            for(int i =0; i<n; i++)
            {
                Console.WriteLine("Enter a Number: ");
                numberList[i] = Convert.ToInt32(Console.ReadLine());
            }
            Average = GetArrayAvg(numberList);
            Console.WriteLine("Average of the Array elements is: " + Average);
            Console.ReadKey();
        }
        static int GetArrayAvg(int [] array)
        {
            int avg;
            int sum=0;
            for(int j=0; j<array.Length; j++)
            {
                sum = sum + array[j];
            }
            avg = sum / array.Length;
            return avg;
        }
    }
}
