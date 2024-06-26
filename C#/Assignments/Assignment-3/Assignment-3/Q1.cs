using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Accounts
    {
        private int Account_no;
        private string Customer_name;
        private string Account_type;
        private char Transaction_type;
        private double Amount;
        private double Balance;

        // Constructor 
        public Accounts(int Account_no, string Customer_name, string Account_type)
        {
            this.Account_no = Account_no;
            this.Customer_name = Customer_name;
            this.Account_type = Account_type;
            this.Balance = 0;   //Assume the account is empty 
        }

        // Deposit or Withdrawal
        public void Updated_Balance(char Transaction_type, double Amount)
        {
            this.Transaction_type = Transaction_type;
            this.Amount = Amount;

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

        // Depositing Amount
        private void Credit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"${amount} deposited successfully.");
        }

        // Withdrawing Amount
        private void Debit(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"${amount} withdrawn successfully.");
            }
            else
            {
                Console.WriteLine("Insufficient balance. Withdrawal process failed.");
            }
        }
        public void ShowData()
        {
            Console.WriteLine("\nAccount Details:");
            Console.WriteLine($"Account Number: {Account_no}");
            Console.WriteLine($"Customer Name: {Customer_name}");
            Console.WriteLine($"Account Type: {Account_type}");
            Console.WriteLine($"Current Balance: ${Balance}");
        }
    }

    class Q1
    {
        static void Main()
        {
            Accounts account = new Accounts(1122, "Tanmayee", "Savings");

            account.Updated_Balance('D', 5000);
            account.Updated_Balance('W', 3000);
            account.Updated_Balance('W', 2600);

            Console.ReadLine();
        }

    }
}