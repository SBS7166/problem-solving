using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArryalistMinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int min, max;
            Console.WriteLine("Enter ArrayList Size:");
            n = Convert.ToInt32(Console.ReadLine());
            ArrayList numberList = new ArrayList(n);
            Console.WriteLine("Enter the ArrayList");
            for(int i=0; i<n; i++)
            {
                i = numberList.Add(Convert.ToInt32(Console.ReadLine()));
            }
            max = GetMax(numberList);
            min = GetMin(numberList);
            Console.WriteLine("Max value of the arrayList: " + max);
            Console.WriteLine("Min value of the arrayList: " + min);
            Console.ReadKey();
        }
        static int GetMax (ArrayList array)
        {
            int max=0;
            for(int i=0; i<array.Count; i++)
            {
                if (Convert.ToInt32(array[i]) > max)
                {
                    max = Convert.ToInt32(array[i]);
                }
                
            }
            return max;
        }
        static int GetMin(ArrayList array)
        {
            int min = Convert.ToInt32(array[0]);
            for (int i = 0; i < array.Count; i++)
            {
                if (Convert.ToInt32(array[i]) < min)
                {
                    min = Convert.ToInt32(array[i]);
                }

            }
            return min;
        }
    }
}
