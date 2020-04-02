namespace MortgageCalculator {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpgData = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbxRate = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.notConsole = new System.Windows.Forms.Label();
            this.tbxValue = new System.Windows.Forms.TextBox();
            this.rbtnAR = new System.Windows.Forms.RadioButton();
            this.rbtnFR = new System.Windows.Forms.RadioButton();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblValue = new System.Windows.Forms.Label();
            this.tbxDuration = new System.Windows.Forms.TextBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.tbxScore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxIncome = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tpgCalc = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnReroll = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.pnlMonth = new System.Windows.Forms.Panel();
            this.lblPaymentInfo = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.pnlRate = new System.Windows.Forms.Panel();
            this.lblInterestInfo = new System.Windows.Forms.Label();
            this.lblInterest = new System.Windows.Forms.Label();
            this.pnlCost = new System.Windows.Forms.Panel();
            this.lblCostInfo = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.sideblock2 = new System.Windows.Forms.Panel();
            this.sideblock1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpgData.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tpgCalc.SuspendLayout();
            this.panel7.SuspendLayout();
            this.pnlMonth.SuspendLayout();
            this.pnlRate.SuspendLayout();
            this.pnlCost.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel1.Controls.Add(this.tabControl1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpgData);
            this.tabControl1.Controls.Add(this.tpgCalc);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(785, 435);
            this.tabControl1.TabIndex = 0;
            // 
            // tpgData
            // 
            this.tpgData.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpgData.Controls.Add(this.panel3);
            this.tpgData.Controls.Add(this.panel2);
            this.tpgData.Controls.Add(this.panel1);
            this.tpgData.Location = new System.Drawing.Point(4, 22);
            this.tpgData.Name = "tpgData";
            this.tpgData.Padding = new System.Windows.Forms.Padding(3);
            this.tpgData.Size = new System.Drawing.Size(777, 409);
            this.tpgData.TabIndex = 0;
            this.tpgData.Text = "Data";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.tbxRate);
            this.panel3.Controls.Add(this.lblRate);
            this.panel3.Controls.Add(this.notConsole);
            this.panel3.Controls.Add(this.tbxValue);
            this.panel3.Controls.Add(this.rbtnAR);
            this.panel3.Controls.Add(this.rbtnFR);
            this.panel3.Controls.Add(this.lblTitle1);
            this.panel3.Controls.Add(this.btnCalculate);
            this.panel3.Controls.Add(this.lblValue);
            this.panel3.Controls.Add(this.tbxDuration);
            this.panel3.Controls.Add(this.lblDuration);
            this.panel3.Controls.Add(this.tbxScore);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.tbxIncome);
            this.panel3.Location = new System.Drawing.Point(197, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(384, 387);
            this.panel3.TabIndex = 16;
            // 
            // tbxRate
            // 
            this.tbxRate.Location = new System.Drawing.Point(167, 214);
            this.tbxRate.Name = "tbxRate";
            this.tbxRate.Size = new System.Drawing.Size(100, 20);
            this.tbxRate.TabIndex = 17;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(81, 217);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(68, 13);
            this.lblRate.TabIndex = 18;
            this.lblRate.Text = "Interest Rate";
            // 
            // notConsole
            // 
            this.notConsole.AutoSize = true;
            this.notConsole.Location = new System.Drawing.Point(81, 327);
            this.notConsole.Name = "notConsole";
            this.notConsole.Size = new System.Drawing.Size(128, 13);
            this.notConsole.TabIndex = 16;
            this.notConsole.Text = "Interest rate output (temp)";
            // 
            // tbxValue
            // 
            this.tbxValue.Location = new System.Drawing.Point(167, 63);
            this.tbxValue.Name = "tbxValue";
            this.tbxValue.Size = new System.Drawing.Size(100, 20);
            this.tbxValue.TabIndex = 1;
            // 
            // rbtnAR
            // 
            this.rbtnAR.AutoSize = true;
            this.rbtnAR.Checked = true;
            this.rbtnAR.Location = new System.Drawing.Point(84, 249);
            this.rbtnAR.Name = "rbtnAR";
            this.rbtnAR.Size = new System.Drawing.Size(63, 17);
            this.rbtnAR.TabIndex = 15;
            this.rbtnAR.TabStop = true;
            this.rbtnAR.Text = "AR loan";
            this.rbtnAR.UseVisualStyleBackColor = true;
            // 
            // rbtnFR
            // 
            this.rbtnFR.AutoSize = true;
            this.rbtnFR.Location = new System.Drawing.Point(84, 272);
            this.rbtnFR.Name = "rbtnFR";
            this.rbtnFR.Size = new System.Drawing.Size(62, 17);
            this.rbtnFR.TabIndex = 14;
            this.rbtnFR.TabStop = true;
            this.rbtnFR.Text = "FR loan";
            this.rbtnFR.UseVisualStyleBackColor = true;
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.BackColor = System.Drawing.Color.Orange;
            this.lblTitle1.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle1.Location = new System.Drawing.Point(77, 12);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Padding = new System.Windows.Forms.Padding(3);
            this.lblTitle1.Size = new System.Drawing.Size(233, 27);
            this.lblTitle1.TabIndex = 0;
            this.lblTitle1.Text = "Mortgage Rate Calculator";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(192, 249);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(81, 66);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(61, 13);
            this.lblValue.TabIndex = 2;
            this.lblValue.Text = "Loan Value";
            // 
            // tbxDuration
            // 
            this.tbxDuration.Location = new System.Drawing.Point(210, 135);
            this.tbxDuration.Name = "tbxDuration";
            this.tbxDuration.Size = new System.Drawing.Size(57, 20);
            this.tbxDuration.TabIndex = 5;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(81, 138);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(113, 13);
            this.lblDuration.TabIndex = 6;
            this.lblDuration.Text = "Length of Loan (years)";
            // 
            // tbxScore
            // 
            this.tbxScore.Location = new System.Drawing.Point(167, 175);
            this.tbxScore.Name = "tbxScore";
            this.tbxScore.Size = new System.Drawing.Size(100, 20);
            this.tbxScore.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Credit Score";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Income (Yearly)";
            // 
            // tbxIncome
            // 
            this.tbxIncome.Location = new System.Drawing.Point(167, 99);
            this.tbxIncome.Name = "tbxIncome";
            this.tbxIncome.Size = new System.Drawing.Size(100, 20);
            this.tbxIncome.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(7, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 387);
            this.panel2.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Location = new System.Drawing.Point(587, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 387);
            this.panel1.TabIndex = 12;
            // 
            // tpgCalc
            // 
            this.tpgCalc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpgCalc.Controls.Add(this.panel7);
            this.tpgCalc.Controls.Add(this.sideblock2);
            this.tpgCalc.Controls.Add(this.sideblock1);
            this.tpgCalc.Location = new System.Drawing.Point(4, 22);
            this.tpgCalc.Name = "tpgCalc";
            this.tpgCalc.Padding = new System.Windows.Forms.Padding(3);
            this.tpgCalc.Size = new System.Drawing.Size(777, 409);
            this.tpgCalc.TabIndex = 1;
            this.tpgCalc.Text = "Calculation";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.btnReroll);
            this.panel7.Controls.Add(this.btnQuit);
            this.panel7.Controls.Add(this.pnlMonth);
            this.panel7.Controls.Add(this.pnlRate);
            this.panel7.Controls.Add(this.pnlCost);
            this.panel7.Controls.Add(this.lblTitle2);
            this.panel7.Location = new System.Drawing.Point(196, 16);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(384, 387);
            this.panel7.TabIndex = 20;
            // 
            // btnReroll
            // 
            this.btnReroll.Location = new System.Drawing.Point(91, 260);
            this.btnReroll.Name = "btnReroll";
            this.btnReroll.Size = new System.Drawing.Size(91, 23);
            this.btnReroll.TabIndex = 12;
            this.btnReroll.Text = "Calculate again";
            this.btnReroll.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(221, 260);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 11;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            // 
            // pnlMonth
            // 
            this.pnlMonth.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlMonth.Controls.Add(this.lblPaymentInfo);
            this.pnlMonth.Controls.Add(this.lblPayment);
            this.pnlMonth.Location = new System.Drawing.Point(91, 132);
            this.pnlMonth.Name = "pnlMonth";
            this.pnlMonth.Size = new System.Drawing.Size(205, 35);
            this.pnlMonth.TabIndex = 8;
            // 
            // lblPaymentInfo
            // 
            this.lblPaymentInfo.AutoSize = true;
            this.lblPaymentInfo.Location = new System.Drawing.Point(3, 13);
            this.lblPaymentInfo.Name = "lblPaymentInfo";
            this.lblPaymentInfo.Size = new System.Drawing.Size(88, 13);
            this.lblPaymentInfo.TabIndex = 1;
            this.lblPaymentInfo.Text = "Monthly Payment";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Location = new System.Drawing.Point(162, 13);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(31, 13);
            this.lblPayment.TabIndex = 4;
            this.lblPayment.Text = "$100";
            // 
            // pnlRate
            // 
            this.pnlRate.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlRate.Controls.Add(this.lblInterestInfo);
            this.pnlRate.Controls.Add(this.lblInterest);
            this.pnlRate.Location = new System.Drawing.Point(91, 194);
            this.pnlRate.Name = "pnlRate";
            this.pnlRate.Size = new System.Drawing.Size(205, 34);
            this.pnlRate.TabIndex = 10;
            // 
            // lblInterestInfo
            // 
            this.lblInterestInfo.AutoSize = true;
            this.lblInterestInfo.Location = new System.Drawing.Point(3, 13);
            this.lblInterestInfo.Name = "lblInterestInfo";
            this.lblInterestInfo.Size = new System.Drawing.Size(102, 13);
            this.lblInterestInfo.TabIndex = 1;
            this.lblInterestInfo.Text = "Interest Rate (Fixed)";
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Location = new System.Drawing.Point(162, 13);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(30, 13);
            this.lblInterest.TabIndex = 4;
            this.lblInterest.Text = "%1.0";
            // 
            // pnlCost
            // 
            this.pnlCost.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlCost.Controls.Add(this.lblCostInfo);
            this.pnlCost.Controls.Add(this.lblCost);
            this.pnlCost.Location = new System.Drawing.Point(91, 72);
            this.pnlCost.Name = "pnlCost";
            this.pnlCost.Size = new System.Drawing.Size(205, 34);
            this.pnlCost.TabIndex = 7;
            // 
            // lblCostInfo
            // 
            this.lblCostInfo.AutoSize = true;
            this.lblCostInfo.Location = new System.Drawing.Point(3, 13);
            this.lblCostInfo.Name = "lblCostInfo";
            this.lblCostInfo.Size = new System.Drawing.Size(124, 13);
            this.lblCostInfo.TabIndex = 1;
            this.lblCostInfo.Text = "Total Cost (With Interest)";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(162, 13);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(40, 13);
            this.lblCost.TabIndex = 4;
            this.lblCost.Text = "$0,000";
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.BackColor = System.Drawing.Color.Orange;
            this.lblTitle2.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle2.Location = new System.Drawing.Point(77, 12);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Padding = new System.Windows.Forms.Padding(3);
            this.lblTitle2.Size = new System.Drawing.Size(233, 27);
            this.lblTitle2.TabIndex = 0;
            this.lblTitle2.Text = "Mortgage Rate Calculator";
            // 
            // sideblock2
            // 
            this.sideblock2.BackColor = System.Drawing.Color.Crimson;
            this.sideblock2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sideblock2.Location = new System.Drawing.Point(586, 16);
            this.sideblock2.Name = "sideblock2";
            this.sideblock2.Size = new System.Drawing.Size(184, 387);
            this.sideblock2.TabIndex = 19;
            // 
            // sideblock1
            // 
            this.sideblock1.BackColor = System.Drawing.Color.Crimson;
            this.sideblock1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sideblock1.Location = new System.Drawing.Point(6, 16);
            this.sideblock1.Name = "sideblock1";
            this.sideblock1.Size = new System.Drawing.Size(184, 387);
            this.sideblock1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpgData.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tpgCalc.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.pnlMonth.ResumeLayout(false);
            this.pnlMonth.PerformLayout();
            this.pnlRate.ResumeLayout(false);
            this.pnlRate.PerformLayout();
            this.pnlCost.ResumeLayout(false);
            this.pnlCost.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpgData;
        private System.Windows.Forms.TabPage tpgCalc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxIncome;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.TextBox tbxDuration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxScore;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox tbxValue;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.RadioButton rbtnAR;
        private System.Windows.Forms.RadioButton rbtnFR;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Panel sideblock2;
        private System.Windows.Forms.Panel sideblock1;
        private System.Windows.Forms.Label lblCostInfo;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Button btnReroll;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Panel pnlMonth;
        private System.Windows.Forms.Label lblPaymentInfo;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Panel pnlRate;
        private System.Windows.Forms.Label lblInterestInfo;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.Panel pnlCost;
        private System.Windows.Forms.Label notConsole;
        private System.Windows.Forms.TextBox tbxRate;
        private System.Windows.Forms.Label lblRate;
    }
}

