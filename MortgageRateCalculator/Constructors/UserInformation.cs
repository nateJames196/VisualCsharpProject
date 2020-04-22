using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortgageRateCalculator {
    class UserInformation {
        public int creditScore { get; set; }
        public double amountOfLoan { get; set; }
        public int lengthOfLoan { get; set; }
        public string income { get; set; }

        public UserInformation(int creditS, double amountL, int length, string income) {
 
            this.creditScore = creditS;
            this.amountOfLoan = amountL;
            this.lengthOfLoan = length;
            this.income = income;
        }
    }
}
