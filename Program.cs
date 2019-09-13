using System;

namespace ClassProject_Deliverable2_ConditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Author:Errol Ennis
             * Date:September 12, 2019
             * Description: Asks students to enter desired grade and displays grade letter.
             */

            Console.WriteLine("Please enter the grade you expect to get in ISM 4300:");

            try
            {
                string input = Console.ReadLine();
                int grade = int.Parse(input);

                if((grade > 97) && (grade < 101))
                {
                    Console.WriteLine("Your selected grade is: " + grade.ToString() + " A+");
                    Console.WriteLine("Good Luck");
                }

                else if ((grade > 91) && (grade < 98))
                {
                    Console.WriteLine("Your selected grade is: " + grade.ToString() + " A");
                    Console.WriteLine("Good Luck");
                }

                else if ((grade > 89) && (grade < 92))
                {
                    Console.WriteLine("Your selected grade is: " + grade.ToString() + " A-");
                    Console.WriteLine("Good Luck");
                }

                else if ((grade > 87) && (grade < 90))
                {
                    Console.WriteLine("Your selected grade is: " + grade.ToString() + " B+");
                    Console.WriteLine("Stay focussed");
                }

                else if ((grade > 81) && (grade < 88))
                {
                    Console.WriteLine("Your selected grade is: " + grade.ToString() + " B");
                    Console.WriteLine("Stay focussed");
                }

                else if ((grade > 79) && (grade < 82))
                {
                    Console.WriteLine("Your selected grade is: " + grade.ToString() + " B-");
                    Console.WriteLine("Stay focussed");
                }

                else if ((grade > 77) && (grade < 80))
                {
                    Console.WriteLine("Your selected grade is: " + grade.ToString() + " C+");
                    Console.WriteLine("Seek help");
                }

                else if ((grade > 71) && (grade < 78))
                {
                    Console.WriteLine("Your selected grade is: " + grade.ToString() + " C");
                    Console.WriteLine("Seek help");
                }

                else if ((grade > 69) && (grade < 72))
                {
                    Console.WriteLine("Your selected grade is: " + grade.ToString() + " C-");
                    Console.WriteLine("Seek help");
                }

                else if ((grade > 67) && (grade < 70))
                {
                    Console.WriteLine("Your selected grade is: " + grade.ToString() + " D+");
                    Console.WriteLine("Yikes");
                }

                else if ((grade > 61) && (grade < 68))
                {
                    Console.WriteLine("Your selected grade is: " + grade.ToString() + " D");
                    Console.WriteLine("Yikes");
                }

                else if ((grade > 59) && (grade < 62))
                {
                    Console.WriteLine("Your selected grade is: " + grade.ToString() + " D-");
                    Console.WriteLine("Yikes");
                }

                else if (grade < 60)
                {
                    Console.WriteLine("Your selected grade is: " + grade.ToString() + " F");
                    Console.WriteLine("Yikes");
                }
            }//end of try

            catch
            {
                Console.WriteLine("Please enter a valid integer");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey(true);
            }//end of catch
        }
    }
}
