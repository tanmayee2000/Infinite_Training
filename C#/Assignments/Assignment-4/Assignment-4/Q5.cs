using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    public class Doctor
    {
        private int Registration_No;
        private string Doctor_name;
        private double Fees;

        //Properties
        public int Reg_no
        {
            get { return Registration_No; }
            set { Registration_No = value; }
        }

        public string name
        {
            get { return Doctor_name; }
            set { Doctor_name = value; }
        }

        public double fees
        {
            get { return Fees; }
            set { Fees = value; }
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Registration Number : {Reg_no}");
            Console.WriteLine($"Doctor's Name : {name}");
            Console.WriteLine($"Fees Charged : {fees}"); 
        }
    }

    class Q5
    {
        static void Main()
        {
            Doctor doctor = new Doctor();

            Console.WriteLine("Enter Registration Number : ");
            doctor.Reg_no = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter Name : ");
            doctor.name = Console.ReadLine();

            Console.WriteLine("\nEnter Fees Charged : ");
            doctor.fees = double.Parse(Console.ReadLine());

            Console.WriteLine("\nDoctor Details : ");
            Console.WriteLine("--------------------------");
            doctor.DisplayDetails();

            Console.Read();
        }
    }
}
