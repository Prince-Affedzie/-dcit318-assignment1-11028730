using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Ticket Price Calculator ===");

            while (true)
            {
                try
                {
                    Console.Write("Enter your age: ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out int age))
                    {
                        if (age < 0 || age > 130)
                        {
                            Console.WriteLine(" Age must be realistic (0 - 130).\n");
                            continue;
                        }

                        decimal price = (age <= 12 || age >= 65) ? 7.00m : 10.00m;

                        Console.WriteLine($"Ticket price: GHC {price}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid age.\n");
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
