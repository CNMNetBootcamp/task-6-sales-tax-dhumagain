//setup

double orderTotal = 0.0;
double stateTax = 0.05;
double localTax = 0.03;
double grandTotal = 0.0;
//     string totalAmount = String.Empty;
string reply = String.Empty;


//input

PUT("Please enter total amount.");
Get orderTotal;


//process
public static void TaxCalculation(double orderTotal, double localTax, double stateTax, double grandTotal)
{
localTax = (orderTotal * localTax);
stateTax = (orderTotal * stateTax);
grandTotal = (orderTotal + localTax + stateTax);

TaxCalculation(orderTotal, localTax, stateTax, grandTotal);


//output
("Total local tax is " + localTax);
("Total state tax is " + stateTax);
("Grand Total amount after tax is " + grandTotal);

PUT "Would you like to perform another calculation? ");

GET reply;