using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC4
{
    class Q2_Delegates
    {
        //Delegate
        public delegate int OperationDelegate(int a, int b);
        static void Main()
        {

            Console.WriteLine("Enter the First Integer : ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter the Second Integer : ");
            int n2 = int.Parse(Console.ReadLine());

            //Delegate instances
            OperationDelegate addDelegate = Addition;
            OperationDelegate subDelegate = Subtraction;
            OperationDelegate mulDelegate = Multiplication;

            
            int sum = Operation(n1, n2, addDelegate);
            int difference = Operation(n1, n2, subDelegate);
            int product = Operation(n1, n2, mulDelegate);

            // Displaying Results
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("\nResults : ");
            Console.WriteLine($"Sum(+) : {sum}");
            Console.WriteLine($"Difference(-) : {difference}");
            Console.WriteLine($"Product(*) : {product}");

            Console.ReadLine(); 
        }

        // Operation Methods
        static int Addition(int a, int b)
        {
            return a + b;
        }

        static int Subtraction(int a, int b)
        {
            return a - b;
        }

        static int Multiplication(int a, int b)
        {
            return a * b;
        }

        // Method to execute a delegate operation
        static int Operation(int a, int b, OperationDelegate operationDelegate)
        {
            return operationDelegate(a, b);
        }
    }
}
