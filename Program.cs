using System;

namespace PaymentCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //in this program I wil take the amount of the loan and the final interest rate to figure out the 
            //monthly loan payments and total value of the loan
            //the formula = principle * (rate/12) * (1 + rate) ^ number of monthly payments/(1 + rate)^ number of monthly payments - 1
            static double MonthlyPayment(double interestRateFinal, double amtOfLoan, int lengthOfLoan)
            {
                int monthsOfLoan = lengthOfLoan * 12;
                
                double moPayment = (amtOfLoan *(interestRateFinal/12) * Math.Pow(interestRateFinal + 1, monthsOfLoan))/Math.Pow(interestRateFinal + 1, monthsOfLoan - 1);
                //to figure out the total cost of the loan, just multiply the payments by the months of the loan
                double totalValueOfLoan = moPayment * monthsOfLoan;
                return moPayment;

             }
                
            
        }
    }
}
