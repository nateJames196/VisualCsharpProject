using System;

namespace InterestRateCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //creat variable for credit score
            int creditScore = 0;

            //variable for interest rate
            double intRate = 0;

            //this is the federal prime interest rate, it is really low right now
            //this will fluctuate, we can import it from a website to get the current
            //fed interest rate, or just leave this as is
            double fedInterestRate = .25;

            //going to need to get the credit score from the user
            //and whether they want an adjustable rate mortgage or
            //fixed, this could be a boolean or a string
            bool isFixedRate = false;

            InterestRateCalc(creditScore, intRate, isFixedRate);
            

        }
        double InterestRateCalc(int credit, double rate, bool fixed)
        {
            //this is how I think we will figure out the interest rates
            //a bunch of if, elseif statements where if credit is higher than 800 we increment
            //intRate by .25, if 750 we increment by .50,(these numbers can change) and so on until if they are below 500
            //we tell them no one is going to lend them crap
            //then we add the fedRate to the intRate and add 2% or more for fixed
            //and add 1/5% for adjustable


        }
    }
}
