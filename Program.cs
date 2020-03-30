using System;
using static System.Console;

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

            //need to do some validation code
            WriteLine("Please enter your credit score:  ");
            creditScore = int.Parse(ReadLine());

            //we could use radio buttons here for true or false?
            WriteLine("Is this a fixed rate mortgage, true or false");
            isFixedRate = bool.Parse(ReadLine());

            WriteLine("Your interest rate is " + InterestRateCalc(creditScore, intRate, fedInterestRate, isFixedRate) + "%");


        }
        static double InterestRateCalc(int credit, double rate, double fedRate, bool fixedRate)
        {
            //this is how I think we will figure out the interest rates
            //a bunch of if, elseif statements where if credit is higher than 800 we increment
            //intRate by .25, if 750 we increment by .50,(these numbers can change) and so on until if they are below 500
            //we tell them no one is going to lend them crap
            //then we add the fedRate to the intRate and add 2% or more for fixed
            //and add 1.5% for adjustable
            int creditScore = credit;
            double intRate = rate;
            double fedInterestRate = fedRate;
            bool isFixedRate = fixedRate;

            //these are the if/elseif statments
            if (creditScore >= 800)
                intRate += .25;
            else if (creditScore >= 750)
                intRate += .50;
            else if (creditScore >= 700)
                intRate += .75;
            else if (creditScore >= 650)
                intRate += 1.0;
            else if (creditScore >= 600)
                intRate += 1.25;
            else if (creditScore >= 550)
                intRate += 1.5;
            else if (creditScore >= 500)
                intRate += 1.75;
            else
            {
                System.Console.WriteLine("Ain't nobody giving you a loan!");
                System.Console.WriteLine("Have a nice day!");
                //leave the program here exit? break?
                ;
            }

            //this is where figure out the interest rate
            if (isFixedRate)
            {
                intRate = 2.0 + intRate + fedInterestRate;
                return intRate;
            } 
            else
            {
                intRate = 1.5 + intRate + fedInterestRate;
                return intRate;
            }
        }
        
    }
}
