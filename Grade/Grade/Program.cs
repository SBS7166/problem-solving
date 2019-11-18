using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
    class Program
    {
        static void Main(string[] args)
        {
            int mark;
            String grade;
            Console.WriteLine("Enter Your marks");
            mark = Convert.ToInt32(Console.ReadLine());
            grade = GetGrade(mark);
            Console.WriteLine("Your Grade: "+ grade);
            Console.ReadKey();
        }
        static string GetGrade(int marks)
        {
            string grade ="";
            if (marks >= 80)
            {
                grade = "A+";
            }
            else if(marks>=70 && marks<=79)
            {
                grade = "A";

            }
            else if(marks>=60 && marks<=69)
            {
                grade = "B";

            }
            else if(marks>=50 && marks<=59)
            {
                grade = "C";
            }
            else if (marks >= 40 && marks <= 49)
            {
                grade = "D";
            }

            else
            {
                grade = "You Failed";
            }

            return grade;
        }
    }
}
