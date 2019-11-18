using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            String firstName, middleName, lastName, fullName;
            firstName = Console.ReadLine();
            middleName = Console.ReadLine();
            lastName = Console.ReadLine();

            fullName = GetFullName(firstName, middleName, lastName);
            Console.WriteLine(fullName);
            Console.ReadKey();

        }

        static string GetFullName(string fname, string mname, string lname)
        {
            string fullName = fname + " " + mname + " " + " " + lname;
            return fullName;
        }
    }
}
