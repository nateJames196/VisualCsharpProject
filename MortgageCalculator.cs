using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MortgageCalculator {
    public partial class Form1 : Form {
        //Static federal interest rate
        public static double FEDRATE = .25;
        public Form1() {
            InitializeComponent();
        }

        static double InterestRateCalc(int credit, double rate, bool fixedRate, double fedRate) {
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
            else {
                System.Console.WriteLine("Ain't nobody giving you a loan!");
                System.Console.WriteLine("Have a nice day!");
                //leave the program here exit? break?
                ;
            }

            //this is where figure out the interest rate
            if (isFixedRate) {
                intRate = 2.0 + intRate + fedInterestRate;
                return intRate;
            } else {
                intRate = 1.5 + intRate + fedInterestRate;
                return intRate;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e) {
            String creditScore = tbxScore.Text;
            int trueScore = 0;
            try {
                trueScore = int.Parse(creditScore);
            } catch (Exception) {
                return;//Error? Stop. immediately.
            }
            //If the AR radio button is NOT checked, then the rate is fixed rate
            Boolean fixedRate = !rbtnAR.Checked;

            String extraRate = tbxRate.Text;
            double trueRate = 0;
            try {
                trueRate = double.Parse(extraRate);
            } catch (Exception) {
                return;
            }

            double interestRateFinal = InterestRateCalc(trueScore, trueRate, fixedRate, FEDRATE);
            notConsole.Text = interestRateFinal + "%";
        }
    }
}
