using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double avg;
            Console.WriteLine("Insert Number of Items: ");
            n = Convert.ToInt32(Console.ReadLine());
            ArrayList varList = new ArrayList(n);
            for(double i=0; i<n; i++)
            {
               i = varList.Add(Convert.ToDouble(Console.ReadLine()));
            }

            Console.WriteLine("Inserted ArrayList: ");
            foreach(double item in varList){

                Console.WriteLine(item);
            }
            avg = GetAvg(varList);
            Console.WriteLine("Average of the ArrayList is: " + avg);
          
            Console.ReadKey();

        }
        static double GetAvg(ArrayList array)
        {
            double s = 0;
            double avg;
            for (int j = 0; j < array.Count; j++)
            {
                
                s = s + Convert.ToDouble(array[j]);
            }
            avg = s / array.Count;

            return avg;

        }
    }
}
