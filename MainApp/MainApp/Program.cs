using System;


namespace MainApp
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                //Console.Clear();
                Console.WriteLine("=== DCIT318 Assignment Launcher ===");
                Console.WriteLine("1. Grade Calculator");
                Console.WriteLine("2. Ticket Price Calculator");
                Console.WriteLine("3. Triangle Type Identifier");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        GradeCalculator.Run();
                        break;
                    case "2":
                        TicketPriceCalculator.Run();
                        break;
                    case "3":
                        TriangleTypeIdentifier.Run();
                        break;
                    case "0":
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Press Enter to try again.");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
