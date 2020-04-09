using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MortgageRateCalculator {
    public partial class Form1 : Form {
        //Static federal interest rate
        static double FEDRATE = .25;

        public Form1() {
            InitializeComponent();
        }

        //in this program I wil take the amount of the loan and the final interest rate to figure out the 
        //monthly loan payments and total value of the loan
        //the formula = principle * (rate/12) * (1 + rate) ^ number of monthly payments/(1 + rate)^ number of monthly payments - 1
        static double MonthlyPayment(double interestRateFinal, double amtOfLoan, int lengthOfLoan) {
            int monthsOfLoan = lengthOfLoan * 12;

            double moPayment = (amtOfLoan * (interestRateFinal / 12) * Math.Pow(interestRateFinal + 1, monthsOfLoan)) / Math.Pow(interestRateFinal + 1, monthsOfLoan - 1);
            return moPayment;

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
                MessageBox.Show("Ain't nobody giving you a loan!", "Invalid credit score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return -999;//
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
            /*
             * Ensure that only the most relevant error indicators are visible
             */
            lblRateErr.Visible = false;
            lblScoreErr.Visible = false;
            lblValueErr.Visible = false;
            lblIncomeErr.Visible = false;

            String creditScore = tbxScore.Text;
            int trueScore;
            try {
                trueScore = int.Parse(creditScore);//TODO: check for negative
            } catch (Exception) {
                lblScoreErr.Visible = true;
                MessageBox.Show("Please enter a valid credit score", "Invalid credit score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //If the AR radio button is NOT checked, then the rate is fixed rate
            Boolean fixedRate = !rbtnAR.Checked;
            string rateType = (fixedRate) ? "fixed" : "adjustible";
            lblInterestInfo.Text = "Interest Rate (" + rateType + ")";

            String extraRate = tbxRate.Text;
            double trueRate;
            try {
                trueRate = double.Parse(extraRate);//TODO: check for negative
            } catch (Exception) {
                lblRateErr.Visible = true;
                MessageBox.Show("Please enter a valid interest rate", "Invalid interest rate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string loanValue = tbxValue.Text;
            double trueValue;
            try {
                if (loanValue.StartsWith("$")) {
                    trueValue = double.Parse(loanValue.Substring(1));
                } else {
                    trueValue = double.Parse(loanValue);
                }
            } catch (Exception) {
                lblRateErr.Visible = true;
                MessageBox.Show("Please enter a valid value for your loan.", "Invalid interest rate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Calculate actual loan interest
            double interestRateFinal = InterestRateCalc(trueScore, trueRate, fixedRate, FEDRATE);
            if (interestRateFinal < 0) {
                //No negative interest rate allowed.
                return;
            }
            lblInterest.Text = string.Format("{0:0}%", interestRateFinal);

            //Calculate monthly payment
            int loanDuration = (rbtn15yr.Checked) ? 15 : 30;
            double loanMonthlyPayment = MonthlyPayment(interestRateFinal, trueValue, loanDuration);
            lblPayment.Text = string.Format("${0:0}", loanMonthlyPayment);

            /*
             * Since interest causes the loan value to change every month, we can only find the
             * total cost of the loan by adding all the monthly payments together 
             */
            double totalLoanValue = loanMonthlyPayment * loanDuration;
            lblCost.Text = string.Format("${0:0}", totalLoanValue);


            //Switch to the calculation tab
            tabControl.SelectedTab = tpgCalc;
        }

        private void btnReroll_Click(object sender, EventArgs e) {
            //Clear values out of the textboxes
            tbxIncome.Text = "";
            tbxRate.Text = "";
            tbxScore.Text = "";
            tbxValue.Text = "";

            //Switch back to the data tab
            tabControl.SelectedTab = tpgData;
        }

        private void btnQuit_Click(object sender, EventArgs e) {
            this.Close();
        }
    }

    
}
