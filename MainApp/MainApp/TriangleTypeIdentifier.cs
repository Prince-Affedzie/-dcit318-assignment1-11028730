using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    internal class TriangleTypeIdentifier
    {
        public static void Run() {

            Console.WriteLine("=== Triangle Type Identifier ===");

            double a = GetSide("first");
            double b = GetSide("second");
            double c = GetSide("third");

            if (IsValidTriangle(a, b, c))
            {
                if (a == b && b == c)
                    Console.WriteLine("Type: Equilateral");
                else if (a == b || b == c || a == c)
                    Console.WriteLine("Type: Isosceles");
                else
                    Console.WriteLine("Type: Scalene");
            }
            else
            {
                Console.WriteLine("The given sides do not form a valid triangle.");
            }
        }

        static double GetSide(string name)
        {
            while (true)
            {
                try
                {
                    Console.Write($"Enter the length of the {name} side: ");
                    string input = Console.ReadLine();

                    if (double.TryParse(input, out double side) && side > 0)
                    {
                        return side;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid positive number.\n");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}\n");
                }
            }
        }

        static bool IsValidTriangle(double a, double b, double c)
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }

    }
}
