using System;

namespace ProgramOne_SN
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ask for the user input */
            Console.WriteLine("Please enter expected grade");

            /* Create empty variables */
            string grade = "";
            int gradePoint = 0;
            
            try
            {
                string userInput = Console.ReadLine();
                gradePoint = int.Parse(userInput);

                if (gradePoint >= 98)
                {
                    grade = "A+";
                }
                else if (gradePoint >= 92)
                {
                    grade = "A";
                }
                else if (gradePoint >= 90)
                {
                    grade = "A-";
                }
                else if (gradePoint >= 88)
                {
                    grade = "B+";
                }
                else if (gradePoint >= 82)
                {
                    grade = "B";
                }
                else if (gradePoint >= 80)
                {
                    grade = "B-";
                }
                else if (gradePoint >= 78)
                {
                    grade = "C+";
                }
                else if (gradePoint >= 72)
                {
                    grade = "C";
                }
                else if (gradePoint >= 70)
                {
                    grade = "C-";
                }
                else if (gradePoint >= 68)
                {
                    grade = "D+";
                }
                else if (gradePoint >= 62)
                {
                    grade = "D";
                }
                else if (gradePoint >= 60)
                {
                    grade = "D-";
                }
                else
                {
                    grade = "F";
                }

                Console.WriteLine("Your grade is " + grade);


            }
            catch
            {
                Console.WriteLine("Make sure you input your grade point as an integer");
                Console.WriteLine("Press any key to quit");
                Console.ReadKey(true);
            }
        }
    }
}


