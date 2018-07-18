using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace teacher_app
{
    class Program
    {

        static double students = 0;
        static double averageGrade = 0;
        static double gradeOfStudent;
        static double result;
        static double teacherAdd = 0;
        static bool setTrue = true;

        static void Main(string[] args)
        {
            


            Console.WriteLine("How many students do you have? ");
            string teacherInput = Console.ReadLine();
            double.TryParse(teacherInput, out students);


            Console.Clear();


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("To get results, write 'get' when you're done writing in all the numbers.");
            Thread.Sleep(3000);


            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;

            Average();
            
            
        }

        public static void Average()
        {
            while (setTrue)
            {
                Console.WriteLine("\nEnter a greade between 1 and 6, where 1 is F and 6 is A.");
                string averageGradeInput = Console.ReadLine();
                teacherAdd++;
                Console.WriteLine("\nThere is " + teacherAdd + " students added to the average");


                if (double.TryParse(averageGradeInput, out gradeOfStudent))
                {
                    averageGrade += gradeOfStudent;
                    Console.WriteLine("\nTotal: " + averageGrade);
                    if (teacherAdd == students)
                    {
                        Console.Clear();
                        result = averageGrade / students;
                        Console.WriteLine("The average grade in the class is " + result);
                        setTrue = false;
                    }
                } else if (averageGradeInput.ToUpper() == "GET")
                {
                    Console.Clear();
                    result = averageGrade / students;
                    Console.WriteLine("The average grade in the class is " + result);
                    setTrue = false;
                }
            }

            Console.WriteLine("\nIf you want to restart the software, please close and reopen it.");
            Console.Read();
        }
    }
}
