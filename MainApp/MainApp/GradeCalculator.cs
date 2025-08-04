using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    internal class GradeCalculator
    {
        public static void Run()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter your grade (0 - 100): ");
                    string input = Console.ReadLine();

                    if (double.TryParse(input, out double grade))
                    {
                        if (grade < 0 || grade > 100)
                        {
                            Console.WriteLine("Grade must be between 0 and 100.\n");
                            continue;
                        }

                        string letterGrade = grade switch
                        {
                            >= 90 => "A",
                            >= 80 => "B",
                            >= 70 => "C",
                            >= 60 => "D",
                            _ => "F"
                        };

                        Console.WriteLine($" Your letter grade is: {letterGrade}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number.\n");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}\n");
                }
            }
        }
    }
}
