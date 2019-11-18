using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int max, min;
            Console.WriteLine("Enter Number of elements: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arrayList = new int[n];
            Console.WriteLine("Enter Array elements: ");
            for (int i=0; i<n; i++)
            {
                arrayList[i] = Convert.ToInt32(Console.ReadLine());
            }
            max = GetMax(arrayList);
            min = GetMin(arrayList);

            Console.WriteLine("Max value of the array is: " + max);
            Console.WriteLine("Min value of the array is: " + min);
            Console.ReadKey(); 
        }

        static int GetMax(int [] arrayList)
        {
            int j;
            int max = 0;
            for(j=0; j<arrayList.Length; j++)
            {
                if (arrayList[j] > max)
                {
                    max = arrayList[j];
                }
            }

            return max;
        }

        static int GetMin(int[] arrayList)
        {
            int j;
            int min = arrayList[0];
            for (j = 0; j < arrayList.Length; j++)
            {
                if (arrayList[j] < min)
                {
                    min = arrayList[j];
                }
            }

            return min;
        }
    }
}
