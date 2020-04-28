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
            TabPage tCalc = tpgCalc;
            tabControl.TabPages.Remove(tCalc);
        }

        //This part of the program takes the amount of the loan and the final interest rate to figure out the 
        //monthly loan payments and total value of the loan
        
        static double MonthlyPayment(double interestRateFinal, double amtOfLoan, int lengthOfLoan) {
            int monthsOfLoan = lengthOfLoan * 12;
            
            //this makes the code more readable, interest rate/12 for months and 100 to account for the percentage
            double interestRate = interestRateFinal / 1200;


            double moPayment = amtOfLoan * interestRate / (1 - (Math.Pow(1 / (1 + interestRate), monthsOfLoan)));

            return moPayment;
        }

        static double InterestRateCalc(int credit, double rate, bool fixedRate, double fedRate) {
            
            //intRate by .25, if 750 we increment by .50,(these numbers can change) and so on 
            //until if they are below 500, and then we say we are sorry, they are not getting a loan
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
                return -999;
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

            //BEGIN VALIDATION
            String creditScore = tbxScore.Text;
            int trueScore;
            try {
                trueScore = int.Parse(creditScore);//TODO: check for negative

                if (trueScore < 500) {
                    lblScoreErr.Visible = true;
                    MessageBox.Show("Your credit score is too low for a loan.", "Invalid credit score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (trueScore > 850) {
                    lblScoreErr.Visible = true;
                    MessageBox.Show("Please enter a real credit score", "Invalid credit score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
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
                if (trueRate <= 0) {
                    lblRateErr.Visible = true;
                    MessageBox.Show("The interest rate must be positive.", "Invalid interest rate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (trueRate >= 100) {
                    lblRateErr.Visible = true;
                    MessageBox.Show("Please enter a smaller interest rate.", "Invalid interest rate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
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

                if (trueValue < 1000) {
                    lblValueErr.Visible = true;
                    MessageBox.Show("Your loan value is too small. Please enter a higher loan.", "Invalid interest rate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            } catch (Exception) {
                lblValueErr.Visible = true;
                MessageBox.Show("Please enter a valid value for your loan.", "Invalid interest rate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //TODO: feed data into UserInformation class

            //Data validation is done, now lets use our data to calculate

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
            double totalLoanValue = loanMonthlyPayment * loanDuration * 12;
            lblCost.Text = string.Format("${0:0}", totalLoanValue);

            //TODO: update UserInformation class with calculated info

            //Calculations are done. Switch to the calculation tab
            tabControl.TabPages.Add(tpgCalc);//Allows us to change to the calculations tab
            tabControl.SelectedTab = tpgCalc;
            tabControl.TabPages.Remove(tpgData);//Hides the data tab
        }

        //Returns to the data tab after clearing out the data
        private void btnReroll_Click(object sender, EventArgs e) {
            //Clear values out of the textboxes
            tbxIncome.Text = "";
            tbxRate.Text = "";
            tbxScore.Text = "";
            tbxValue.Text = "";

            //Switch back to the data tab
            tabControl.TabPages.Add(tpgData);//Alows us to change to the data tab
            tabControl.SelectedTab = tpgData;
            tabControl.TabPages.Remove(tpgCalc);//Hides the calculations tab
        }

        private void btnQuit_Click(object sender, EventArgs e) {
            this.Close();
        }

        //Returns to the data tab, but doesn't clear the data out first
        private void btnRetry_Click(object sender, EventArgs e) {
            //Switch back to the data tab
            tabControl.TabPages.Add(tpgData);//Alows us to change to the data tab
            tabControl.SelectedTab = tpgData;
            tabControl.TabPages.Remove(tpgCalc);//Hides the calculations tab

            //Ideally this would also update the db, but it doesn't need to.
        }
    }

    
}
