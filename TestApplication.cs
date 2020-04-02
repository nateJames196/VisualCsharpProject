using System;

namespace GroupProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //the test main creates a new instance of UserInformation and throws it into the MortgageCalculation class
            UserInformation test = new UserInformation("4977","Nelson","593",12,12.2,12,"nelson",12.7);
            //the Mortgage calculation class takes in the new UserInformation class and makes the calculation updates the userInfo with the new mortgagepayment then sends it to the database
            MortgageCalculation calc = new MortgageCalculation(test);
            //after we do all the calculation to get the new mortgageCalculation we just hit the newly updated UserInformation class from the MortgageCalculation class.
            Console.WriteLine(calc.userInfo.mortgagePayment);
        }
    }
}
