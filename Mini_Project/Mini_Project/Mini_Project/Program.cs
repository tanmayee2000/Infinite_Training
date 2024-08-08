using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opening Page
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("---------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("******** RAILWAY RESERVATION PORTAL ********");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("---------------------------------------------");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n     ___________________");
                Console.WriteLine("\n    | CONTENTS :        |");
                Console.WriteLine("    | 1. Admin Page     |");
                Console.WriteLine("    | 2. User Page      |");
                Console.WriteLine("    | 3. Exit           |");
                Console.WriteLine("     ___________________");
               
                Console.Write("\n Choose an option : ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AdminOperations.AdminLogin();
                        break;
                    case "2":
                        UserOperations.UserMenu();
                        break;
                    case "3":
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid choice. Try again.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }

    //If Chosen Admin
    public static class AdminOperations
    {
        private static Mini_ProjectEntities db = new Mini_ProjectEntities();

        //Admin Login Page
        public static void AdminLogin()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("* ADMIN LOGIN *");
            Console.WriteLine("---------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nEnter Username: ");
            var username = Console.ReadLine();
            Console.Write("\nEnter Password: ");
            var password = Console.ReadLine();

            var admin = db.Admins.SingleOrDefault(u => u.Username == username && u.Password == password);

            if (admin != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nLogin successful.");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("\nRedirecting you to the Admin Page ...");
                Console.ReadKey();
                AdminMenu();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid credentials. Try again.");
                Console.ReadKey();
            }
        }
        public static void AdminMenu()
        {
            
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("***** WELCOME ADMIN *****");
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nOPERATIONS :");
                Console.WriteLine("\n1. Add Train");
                Console.WriteLine("2. Delete Train");
                Console.WriteLine("3. Modify Status of Train");
                Console.WriteLine("4. View All Trains");
                Console.WriteLine("5. Back");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("\nWhat do you wish to do?\nOption : ");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddTrain();
                        break;
                    case "2":
                        DeleteTrain();
                        break;
                    case "3":
                        ModifyTrainStatus();
                        break;
                    case "4":
                        ViewTrains();
                        break;
                    case "5":
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }

        //ADDING A TRAIN - OPERATION BY THE ADMIN
        private static void AddTrain()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nEnter Details of the Train to be Added : ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n * Enter Train Number: ");
            var trainNo = int.Parse(Console.ReadLine());

            var existingTrain = db.Trains.SingleOrDefault(t => t.TrainNo == trainNo);
            if (existingTrain != null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Exception : Train with this number already exists.");
                Console.ReadKey();
                return;
            }

            Console.Write("* Enter Train Name: ");
            var trainName = Console.ReadLine();
            Console.Write("* Enter Source Station: ");
            var fromStation = Console.ReadLine();
            Console.Write("* Enter Destination Station: ");
            var toStation = Console.ReadLine();
            Console.Write("* Enter Class of Travel (Sleeper/AC): ");
            var classOfTravel = Console.ReadLine();
            Console.Write("* Enter Seats Available: ");
            var seatsAvailable = int.Parse(Console.ReadLine());
            Console.Write("* Enter Status (Active/Inactive): ");
            var status = Console.ReadLine();
            Console.Write("* Enter Train Status (On-Time/Delayed): ");
            var trainStatus = Console.ReadLine();

            var train = new Train
            {
                TrainNo = trainNo,
                TrainName = trainName,
                FromStation = fromStation,
                ToStation = toStation,
                ClassOfTravel = classOfTravel,
                SeatsAvailable = seatsAvailable,
                Status = status,
                TrainStatus = trainStatus
            };

            db.Trains.Add(train);       //Adds the Train details to the Trains Table
            db.SaveChanges();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n*** Train Added Successfully ***");
            Console.ReadKey();
        }

        //DELETING A TRAIN
        private static void DeleteTrain()
        {
            //Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("DELETE A TRAIN");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nEnter Train Number to delete: ");
            var trainNo = int.Parse(Console.ReadLine());

            var train = db.Trains.SingleOrDefault(t => t.TrainNo == trainNo);
            if (train == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Train not found.");
                Console.ReadKey();
                return;
            }

            db.Trains.Remove(train);
            db.SaveChanges();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n*** Train Deleted Successfully ***");
            Console.ReadKey();
        }

        //MODIFYING STATUS OF TRAINS
        private static void ModifyTrainStatus()
        {
            //Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("MODIFY TRAIN STATUS");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nEnter Train Number to modify status: ");
            var trainNo = int.Parse(Console.ReadLine());

            var train = db.Trains.SingleOrDefault(t => t.TrainNo == trainNo);
            if (train == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error : Train Not found.");
                Console.ReadKey();
                return;
            }

            Console.Write("\n * Enter New Status (Active/Inactive): ");
            var status = Console.ReadLine();
            Console.Write("\n * Enter New Train Status (On-Time/Delayed): ");
            var trainStatus = Console.ReadLine();

            train.Status = status;
            train.TrainStatus = trainStatus;
            db.SaveChanges();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n*** Train status updated successfully ***");
            Console.ReadKey();
        }

        private static void ViewTrains()
        {
            Console.WriteLine("-- TRAINS LIST --\n");
            var trains = db.Trains.ToList();

            Console.WriteLine("______________________________________________________________________________________________________________________");
            Console.WriteLine("| TrainNo | TrainName     | FromStation    | ToStation    | ClassOfTravel  | SeatsAvailable | Status  | TrainStatus  |");
            Console.WriteLine("____________________________________________________________________________________________________________________");
            foreach (var train in trains)
            {
                Console.WriteLine($"| {train.TrainNo}\t | {train.TrainName}\t | {train.FromStation}\t | {train.ToStation}\t | {train.ClassOfTravel}\t | {train.SeatsAvailable}\t | {train.Status}\t | {train.TrainStatus}   |");
            }
            Console.ReadLine();
        }
    }

    //USER OPERTIONS
    public static class UserOperations
    {
        private static Mini_ProjectEntities db = new Mini_ProjectEntities();
        public static void UserMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("***** USER PAGE *****");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n1. Register a New User");
                Console.WriteLine("2. Login Existing User");
                Console.WriteLine("3. Back");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("\nChoose an Option : ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        RegisterUser();
                        break;
                    case "2":
                        LoginUser();
                        break;
                    case "3":
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid choice. Try again.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private static void RegisterUser()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("* NEW USER REGISTRATION *");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nEnter Username: ");
            var username = Console.ReadLine();
            Console.Write("\nEnter Password: ");
            var password = Console.ReadLine();

            var user = new User { Username = username, Password = password };

            db.Users.Add(user);
            db.SaveChanges();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n** User registered successfully **");
            Console.ReadKey();
        }

        private static void LoginUser()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("USER LOGIN");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nEnter Username: ");
            var username = Console.ReadLine();
            Console.Write("\nEnter Password: ");
            var password = Console.ReadLine();

            var user = db.Users.SingleOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nLogin Successful.");
                Console.ReadKey();
                UserActionMenu(user);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nERROR! Invalid credentials. Try again.");
                Console.ReadKey();
            }
        }

        private static void UserActionMenu(User user)
        {
            
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Hi There " + user.Username + " !");
                //Console.ForegroundColor = ConsoleColor.Magenta;
                //Console.WriteLine("\nUSER MENU :");
                //Console.WriteLine("------------");
                Console.ForegroundColor = ConsoleColor.White;

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\nUSER MENU : ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n1. View All Trains");
                Console.WriteLine("2. Book a Ticket");
                Console.WriteLine("3. Cancel a Ticket");
                Console.WriteLine("4. Logout");

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("\nWhat would you like to do today?\nOption : ");
                Console.ForegroundColor = ConsoleColor.White;
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ViewTrains();
                        break;
                    case "2":
                        BookTicket(user);
                        break;
                    case "3":
                        CancelTicket(user);
                        break;
                    case "4":
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR! Invalid choice. Try again.");
                        Console.ReadKey();
                        Console.ForegroundColor = ConsoleColor.White;
                        break;

                }
            }
        }

        private static void ViewTrains()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-- TRAINS LIST --\n");
            Console.ForegroundColor = ConsoleColor.White;
            var trains = db.Trains.ToList();
           
            Console.WriteLine("______________________________________________________________________________________________________________________");
            Console.WriteLine("| TrainNo | TrainName     | FromStation   | ToStation   | ClassOfTravel  | SeatsAvailable | Status  | TrainStatus  |");
            Console.WriteLine("____________________________________________________________________________________________________________________");
            foreach (var train in trains)
            {
                Console.WriteLine($"| {train.TrainNo}\t | {train.TrainName}\t | {train.FromStation}\t | {train.ToStation}\t | {train.ClassOfTravel}\t | {train.SeatsAvailable}\t | {train.Status}\t | {train.TrainStatus}   |");
            }
            Console.ReadLine();
        }

        private static void BookTicket(User user)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n-- BOOK A TICKET -- \n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("* Enter Train Number: ");
            var trainNo = int.Parse(Console.ReadLine());

            var train = db.Trains.SingleOrDefault(t => t.TrainNo == trainNo);
            if (train == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Train not found.");
                Console.ReadKey();
                return;
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("* Enter Class of Travel (Sleeper/1AC/2AC/3AC): ");
            var classOfTravel = Console.ReadLine();

            Console.Write("* Enter Date of Journey (YYYY-MM-DD): ");
            var dateOfJourney = DateTime.Parse(Console.ReadLine());

            Console.Write("* Enter Number of Seats to Book (Max. 3): ");
            var seatsToBook = int.Parse(Console.ReadLine());

            if (seatsToBook > 3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nError! Cannot Book more than 3 seats per User.");
                Console.WriteLine("------------------------------------------------");
                Console.ReadKey();
                return;
            }

            if (seatsToBook > train.SeatsAvailable)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Exception : Not Enough seats available to Book.");
                Console.ReadKey();
                return;
            }

            Console.Write("* Enter Gender: ");
            var gender = Console.ReadLine();

            Console.Write("* Senior Citizen Quota (Yes/No): ");
            var seniorCitizenQuota = Console.ReadLine();

            // Determine price based on class of travel
            decimal priceOfTicket;

            switch (classOfTravel)
            {
                case "1AC":
                    priceOfTicket = 3500m;
                    break;
                case "2AC":
                    priceOfTicket = 3000m;
                    break;
                case "3AC":
                    priceOfTicket = 2700m;
                    break;
                case "Sleeper":
                    priceOfTicket = 120m;
                    break;
                default:
                    throw new ArgumentException("Invalid Class of Travel");
                    Console.ReadKey();
            }

            var booking = new Booking
            {
                UserId = user.UserId,
                TrainNo = train.TrainNo,
                ClassOfTravel = classOfTravel,
                DateOfJourney = dateOfJourney,
                PriceOfTicket = priceOfTicket,
                Gender = gender,
                SeniorCitizenQuota = seniorCitizenQuota,
                SeatsBooked = seatsToBook
            };

            db.Bookings.Add(booking);
            train.SeatsAvailable -= seatsToBook;
            db.SaveChanges();

            //Printing the Booked Ticket

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Ticket booked successfully.");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n--- Ticket Details ---");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("|{0,-15}|{1,-25}|", "Field", "Details");
            Console.WriteLine("|{0,-15}|{1,-25}|", "-----------------", "-------------------------");
            Console.WriteLine("|{0,-15}|{1,-25}|", "Booking ID:", booking.BookingId);
            Console.WriteLine("|{0,-15}|{1,-25}|", "Train Number:", train.TrainNo);
            Console.WriteLine("|{0,-15}|{1,-25}|", "Train Name:", train.TrainName);
            Console.WriteLine("|{0,-15}|{1,-25}|", "From Station:", train.FromStation);
            Console.WriteLine("|{0,-15}|{1,-25}|", "To Station:", train.ToStation);
            Console.WriteLine("|{0,-15}|{1,-25}|", "Date of Journey:", booking.DateOfJourney);
            Console.WriteLine("|{0,-15}|{1,-25}|", "Class of Travel:", booking.ClassOfTravel);
            Console.WriteLine("|{0,-15}|{1,-25}|", "Seats Booked:", booking.SeatsBooked);
            Console.WriteLine("|{0,-15}|{1,-25}|", "Price per Seat:", booking.PriceOfTicket);
            Console.WriteLine("|{0,-15}|{1,-25}|", "Total Price:", (booking.PriceOfTicket * booking.SeatsBooked));
            Console.WriteLine("|{0,-15}|{1,-25}|", "Gender:", booking.Gender);
            Console.WriteLine("|{0,-15}|{1,-25}|", "Senior Citizen Quota:", booking.SeniorCitizenQuota);
            Console.WriteLine("-------------------------------");
            Console.WriteLine();
        }

        private static void CancelTicket(User user)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-- TICKET CANCELLATION --\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("* Enter Booking ID: ");
            var bookingId = int.Parse(Console.ReadLine());

            var booking = db.Bookings.SingleOrDefault(b => b.BookingId == bookingId && b.UserId == user.UserId);
            if (booking == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error ! Booking Not found.");
                Console.ReadKey();
                return;
            }

            var train = db.Trains.SingleOrDefault(t => t.TrainNo == booking.TrainNo);
            if (train == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Train Not Found.");
                Console.ReadKey();
                return;
            }

            train.SeatsAvailable += booking.SeatsBooked;

            var cancellation = new Cancellation
            {
                BookingId = bookingId,
                CancellationDate = DateTime.Now
            };

            db.Cancellations.Add(cancellation);
            //db.Bookings.Remove(booking);
            db.SaveChanges();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Ticket cancelled successfully.");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n--- Cancellation Details ---");
            Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine("|{0,-15}|{1,-25}|", "------------------------------------");
            Console.WriteLine("|{0,-15}|{1,-25}|", "Booking ID:", booking.BookingId);
            Console.WriteLine("|{0,-15}|{1,-25}|", "Train Number:", train.TrainNo);
            Console.WriteLine("|{0,-15}|{1,-25}|", "Train Name:", train.TrainName);
            Console.WriteLine("|{0,-15}|{1,-25}|", "From Station:", train.FromStation);
            Console.WriteLine("|{0,-15}|{1,-25}|", "To Station:", train.ToStation);
            Console.WriteLine("|{0,-15}|{1,-25}|", "Date of Journey:", booking.DateOfJourney);
            Console.WriteLine("|{0,-15}|{1,-25}|", "Class of Travel:", booking.ClassOfTravel);
            Console.WriteLine("|{0,-15}|{1,-25}|", "Seats Booked:", booking.SeatsBooked);
            Console.WriteLine("|{0,-15}|{1,-25}|", "Price per Seat:", booking.PriceOfTicket);
            Console.WriteLine("|{0,-15}|{1,-25}|", "Total Price:", (booking.PriceOfTicket * booking.SeatsBooked));
            Console.WriteLine("|{0,-15}|{1,-25}|", "Cancellation Date:", cancellation.CancellationDate);
            Console.WriteLine("-------------------------------");
            Console.WriteLine();
        }
    }
}
