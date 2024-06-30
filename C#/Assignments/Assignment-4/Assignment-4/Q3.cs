using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    public class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException()
        {
        }

        public InsufficientBalanceException(string message) : base(message)
        {
        }

        public InsufficientBalanceException(string message, Exception otherException) : base(message, otherException)
        {
        }
    }

    public class Accounts
    {
        private int Account_no;
        private string Customer_name;
        private string Account_type;
        private double Balance;

        // Constructor 
        public Accounts(int Account_no, string Customer_name, string Account_type)
        {
            this.Account_no = Account_no;
            this.Customer_name = Customer_name;
            this.Account_type = Account_type;
            this.Balance = 0;   // Assume the account is empty 
        }

        // Deposit or Withdrawal
        public void Updated_Balance(char Transaction_type, double Amount)
        {
            try
            {
                switch (Transaction_type)
                {
                    case 'D':
                        Credit(Amount);
                        break;
                    case 'W':
                        Debit(Amount);
                        break;
                    default:
                        Console.WriteLine("Invalid Transaction type.");
                        break;
                }

            ShowData(); // Updated Account Information
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Argument Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error: {ex.Message}");
            }
        }

        // Depositing Amount
        private void Credit(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive and greater than zero.");
            }

            Balance += amount;
            Console.WriteLine($"{amount} deposited successfully.");
        }

        // Withdrawing Amount
        private void Debit(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be positive and greater than zero.");
            }

            if (amount > Balance)
            {
                throw new InsufficientBalanceException("Insufficient balance to withdraw.");
            }

            Balance -= amount;
            Console.WriteLine($"{amount} withdrawn successfully.");
        }

        public void ShowData()
        {
            Console.WriteLine("\nAccount Details:");
            Console.WriteLine($"Account Number: {Account_no}");
            Console.WriteLine($"Customer Name: {Customer_name}");
            Console.WriteLine($"Account Type: {Account_type}");
            Console.WriteLine($"Current Balance: {Balance}");
        }
    }

    class Q3
    {
        static void Main()
        {
            try
            {
                Accounts account = new Accounts(1122, "Tanmayee", "Savings");

                account.Updated_Balance('D', 5000);
                account.Updated_Balance('W', 3000);
                account.Updated_Balance('W', 2600);
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Argument Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error: {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}
