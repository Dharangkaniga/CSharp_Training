using System;


namespace TrainManagementSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n===========================================================");
                Console.WriteLine("           TRAIN RESERVATION MANAGEMENT SYSTEM             ");
                Console.WriteLine("===========================================================");
                Console.WriteLine("1. Admin");
                Console.WriteLine("2. Customer");
                Console.WriteLine("3. Exit");
                Console.Write("Enter choice: ");

                if (!int.TryParse(Console.ReadLine(), out int mainChoice))
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }

                switch (mainChoice)
                {
                    case 1:
                        AdminMenu();
                        break;

                    case 2:
                        CustomerMenu();
                        break;

                    case 3:
                        Console.WriteLine("Thank you!!!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }

        static void AdminMenu()
        {
            Admin admin = new Admin();

            Console.WriteLine("\n====== ADMIN MENU ======");
            Console.WriteLine("1. Add Train");
            Console.WriteLine("2. View Train");
            Console.WriteLine("3. Delete Train");
            Console.WriteLine("4. Back");
            Console.Write("Enter choice: ");

            if (!int.TryParse(Console.ReadLine(), out int ch))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            switch (ch)
            {
                case 1:
                    admin.AddTrain();
                    break;

                case 2:
                    admin.ViewTrain();
                    break;

                case 3:
                    admin.DeleteTrain();
                    break;

                case 4:
                    return;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }

        static void CustomerMenu()
        {
            Customer customer = new Customer();

            Console.WriteLine("\n====== CUSTOMER MENU ======");
            Console.WriteLine("1. View Trains");
            Console.WriteLine("2. Book Ticket");
            Console.WriteLine("3. Cancel Ticket");
            Console.WriteLine("4. Back");
            Console.Write("Enter choice: ");

            if (!int.TryParse(Console.ReadLine(), out int ch))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            switch (ch)
            {
                case 1:
                    customer.ViewTrain();
                    break;

                case 2:
                    customer.BookTicket();
                    break;

                case 3:
                    customer.CancelTicket();
                    break;

                case 4:
                    return;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}