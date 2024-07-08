using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_ConcessionClassLibrary
{
    public class ConcessionLibrary
    {
        public const int TotalFare = 500;

        public void CalculateConcession(int age)
        {
            if (age <= 5)
            { 
                Console.WriteLine("\n ^_^ Little Champs - Free Ticket ^_^ ");
            }
            else if (age > 60)
            {
                double concessionAmount = TotalFare * 0.3;
                double discountedFare = TotalFare - concessionAmount;
                Console.WriteLine($"\nSenior Citizen. \nCalculated Fare: {discountedFare}");
            }
            else
            {
                Console.WriteLine($"\nTicket Booked. \nTotal Fare : {TotalFare}");
            }
        }
    }
}
