using System;
using System.Collections.Generic;
using System.Text;

namespace GroupProject
{
    class UserInformation
    {
        public string address { get; set; }
        public string name { get; set; }
        public string socialSecurity { get; set; }
        public int creditScore { get; set; }
        public double amountOfLoan { get; set; }
        public int lengthOfLoan { get; set; }
        public string typeOfLoan { get; set; }
        public double income { get; set; }
        public double mortgagePayment { get; set; }

        public UserInformation(string address, string name, string social, int creditS, double amountL, int length, string type, double income) 
        {
            this.address = address;
            this.name = name;
            this.socialSecurity = social;
            this.creditScore = creditS;
            this.amountOfLoan = amountL;
            this.lengthOfLoan = length;
            this.typeOfLoan = type;
            this.income = income;
        }
    }
}
