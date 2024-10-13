using System.Numerics;

namespace grade_calculator
{
    /*
     * Lydia Jin
     * IGME.201
     * due Oct 13, 2024
     */

    internal class Program
    {
        static void Main(string[] args)
        {

            //string variable to hold name of student 
            string StudentName = "Lydia";

            //array of grades
            int[] grades = {100, 92, 87, 200, -20, 52, 82, 75, 67, 88 };

            Console.WriteLine("Welcome " + StudentName + "!");
            Console.WriteLine("Here are your grades: ");

            //loop through array 
            int total = 0;

            for (int i = 0; i < grades.Length; i++)
            { 
                int grade = grades[i];
                Console.WriteLine(grade);

                if (grade >= 90 && grade <= 100)
                {
                    Console.WriteLine("This grade is an A!");
                    if (grade == 100)
                    {
                        Console.WriteLine("WOW! A perfect score!");
                    }
                }
                else if (grade >= 80 && grade <= 89)
                {
                    Console.WriteLine("This grade is a B");
                }
                else if (grade >= 70 && grade <= 79)
                {
                    Console.WriteLine("This grade is a C");
                } 
                else if (grade >= 65 && grade <= 69)
                { 
                    Console.WriteLine("This grade is a D");
                }
                else if (grade >= 0 && grade <= 64)
                {
                    Console.WriteLine("This grade is an F");
                }
                else
                {
                    Console.WriteLine("This is out of the range of 0-100. How did you even get this grade?");

                }
                total += grade;
            }

            //average for the grade 
            double average = total / 10;

            //final caulculated average
            Console.WriteLine("Your final calculated average is: " + average);
            Console.WriteLine("We have displayed all grades for " + StudentName);


        }
    }
}
