using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeName
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            do
            {
                int mark;
                String firstName, middleName, lastName, fullName, grade, subject;
                Console.WriteLine("Enter First Name: ");
                firstName = Console.ReadLine();
                Console.WriteLine("Enter Middle Name: ");
                middleName = Console.ReadLine();
                Console.WriteLine("Enter last Name: ");
                lastName = Console.ReadLine();
                Console.WriteLine("Enter Your Subject: ");
                subject = Console.ReadLine();
                Console.WriteLine("Enter Your Marks: ");
                mark = Convert.ToInt32(Console.ReadLine());
                fullName = GetFullName(firstName, middleName, lastName);

                Console.Write("Hello " + fullName + ".");
                if (mark >= 40)
                {
                    grade = GetPassGrade(mark);
                    Console.Write(" Congratulation! You have passed in " + subject + " and your grade is: " + grade);
                }
                else
                {
                    grade = GetFailingGrade(mark);
                    Console.WriteLine(grade);
                }
                Console.WriteLine("\nDo you wish to continue(y/n)?");
                ch = Convert.ToChar(Console.ReadLine());
                
            } while (ch == 'y');

            Console.ReadKey();
        }

        static string GetFullName(string fName, string mName, string lName)
        {
            string fullName;
            fullName = fName + " " + mName + " " + lName;
            return fullName;
        }

        static string GetPassGrade(int mark)
        {
            string grade;
            if (mark >= 80)
            {
                grade = "A+";
            }
            else if(mark<=79 && mark>=70){
                grade = "A";
            }
            else if (mark <= 69 && mark >= 60)
            {
                grade = "B";
            }
            else if (mark <= 59 && mark >= 50)
            {
                grade = "C";
            }
            else if (mark <= 49 && mark >= 40)
            {
                grade = "D";
            }

            else
            {
                grade = "F";
            }

            return grade;
        }
        static string GetFailingGrade(int mark)
        {
            string grade;
            
            grade = "Sorry! you have failed. Please try again!";
           
            return grade;
        }

       
    }
}
