using System;

namespace Task6
{
    class Program
    {
        public static void TaxCalculation(double orderTotal, double localTax, double stateTax, double grandTotal)
        {
            localTax = (orderTotal * localTax);
            stateTax = (orderTotal * stateTax);
            grandTotal = (orderTotal + localTax + stateTax);

            Console.WriteLine("Total local tax is " + localTax);
            Console.WriteLine("Total state tax is " + stateTax);
            Console.WriteLine("Grand Total amount after tax is " + grandTotal);

        }

        static void Main(string[] args)
        {
            //setup

            double orderTotal=0.0;
            double stateTax = 0.05;
            double localTax = 0.03;
            double grandTotal = 0.0;
       //     string totalAmount = String.Empty;
            string reply = String.Empty;


            do
            {
                Console.WriteLine("Please enter total amount. ");
                orderTotal =double.Parse(Console.ReadLine());

                TaxCalculation(orderTotal, localTax, stateTax, grandTotal);


                Console.WriteLine("Would you like to perform another calculation? ");

                reply= Console.ReadLine();

            } while (reply == "Y");

        }
               
        
    }
}

