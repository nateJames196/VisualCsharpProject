﻿// File:    Form1.Designer.cs
// Project: COP2360C Group Project
// Author:  Nathan James, Karl Meyer
// History: Version 1.0 April 29, 2020
namespace MortgageRateCalculator {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpgData = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.rbtnFR = new System.Windows.Forms.RadioButton();
            this.rbtnAR = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rbtn30yr = new System.Windows.Forms.RadioButton();
            this.tbxIncome = new System.Windows.Forms.TextBox();
            this.rbtn15yr = new System.Windows.Forms.RadioButton();
            this.lblIncome = new System.Windows.Forms.Label();
            this.lblIncomeErr = new System.Windows.Forms.Label();
            this.lblRateErr = new System.Windows.Forms.Label();
            this.lblScoreErr = new System.Windows.Forms.Label();
            this.lblValueErr = new System.Windows.Forms.Label();
            this.tbxValue = new System.Windows.Forms.TextBox();
            this.tbxRate = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.tbxScore = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tpgCalc = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnRetry = new System.Windows.Forms.Button();
            this.btnReroll = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnlCost = new System.Windows.Forms.Panel();
            this.lblCostInfo = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.pnlMonth = new System.Windows.Forms.Panel();
            this.lblPaymentInfo = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.pnlRate = new System.Windows.Forms.Panel();
            this.lblInterestInfo = new System.Windows.Forms.Label();
            this.lblInterest = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.sideblock2 = new System.Windows.Forms.Panel();
            this.sideblock1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tpgData.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tpgCalc.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pnlCost.SuspendLayout();
            this.pnlMonth.SuspendLayout();
            this.pnlRate.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel1.Controls.Add(this.tabControl);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.tpgData);
            this.tabControl.Controls.Add(this.tpgCalc);
            this.tabControl.Location = new System.Drawing.Point(3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(785, 435);
            this.tabControl.TabIndex = 0;
            // 
            // tpgData
            // 
            this.tpgData.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpgData.Controls.Add(this.panel3);
            this.tpgData.Controls.Add(this.panel2);
            this.tpgData.Controls.Add(this.panel1);
            this.tpgData.Location = new System.Drawing.Point(4, 25);
            this.tpgData.Name = "tpgData";
            this.tpgData.Padding = new System.Windows.Forms.Padding(3);
            this.tpgData.Size = new System.Drawing.Size(777, 406);
            this.tpgData.TabIndex = 0;
            this.tpgData.Text = "Data";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.lblTitle1);
            this.panel3.Location = new System.Drawing.Point(197, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(384, 387);
            this.panel3.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel5.Controls.Add(this.btnCalculate);
            this.panel5.Controls.Add(this.rbtnFR);
            this.panel5.Controls.Add(this.rbtnAR);
            this.panel5.Location = new System.Drawing.Point(49, 285);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(291, 71);
            this.panel5.TabIndex = 21;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Red;
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculate.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.btnCalculate.FlatAppearance.BorderSize = 3;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(172, 19);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 33);
            this.btnCalculate.TabIndex = 19;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // rbtnFR
            // 
            this.rbtnFR.AutoSize = true;
            this.rbtnFR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnFR.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rbtnFR.Location = new System.Drawing.Point(40, 42);
            this.rbtnFR.Name = "rbtnFR";
            this.rbtnFR.Size = new System.Drawing.Size(97, 17);
            this.rbtnFR.TabIndex = 14;
            this.rbtnFR.TabStop = true;
            this.rbtnFR.Text = "Fixed rate loan";
            this.rbtnFR.UseVisualStyleBackColor = true;
            // 
            // rbtnAR
            // 
            this.rbtnAR.AutoSize = true;
            this.rbtnAR.Checked = true;
            this.rbtnAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnAR.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rbtnAR.Location = new System.Drawing.Point(40, 19);
            this.rbtnAR.Name = "rbtnAR";
            this.rbtnAR.Size = new System.Drawing.Size(118, 17);
            this.rbtnAR.TabIndex = 15;
            this.rbtnAR.TabStop = true;
            this.rbtnAR.Text = "Adjustible rate loan";
            this.rbtnAR.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel4.Controls.Add(this.rbtn30yr);
            this.panel4.Controls.Add(this.tbxIncome);
            this.panel4.Controls.Add(this.rbtn15yr);
            this.panel4.Controls.Add(this.lblIncome);
            this.panel4.Controls.Add(this.lblIncomeErr);
            this.panel4.Controls.Add(this.lblRateErr);
            this.panel4.Controls.Add(this.lblScoreErr);
            this.panel4.Controls.Add(this.lblValueErr);
            this.panel4.Controls.Add(this.tbxValue);
            this.panel4.Controls.Add(this.tbxRate);
            this.panel4.Controls.Add(this.lblRate);
            this.panel4.Controls.Add(this.lblValue);
            this.panel4.Controls.Add(this.tbxScore);
            this.panel4.Controls.Add(this.lblScore);
            this.panel4.Location = new System.Drawing.Point(49, 54);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(291, 214);
            this.panel4.TabIndex = 20;
            // 
            // rbtn30yr
            // 
            this.rbtn30yr.AutoSize = true;
            this.rbtn30yr.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rbtn30yr.Location = new System.Drawing.Point(139, 171);
            this.rbtn30yr.Name = "rbtn30yr";
            this.rbtn30yr.Size = new System.Drawing.Size(85, 17);
            this.rbtn30yr.TabIndex = 30;
            this.rbtn30yr.Text = "30 year loan";
            this.rbtn30yr.UseVisualStyleBackColor = true;
            // 
            // tbxIncome
            // 
            this.tbxIncome.Location = new System.Drawing.Point(139, 135);
            this.tbxIncome.Name = "tbxIncome";
            this.tbxIncome.Size = new System.Drawing.Size(100, 20);
            this.tbxIncome.TabIndex = 26;
            // 
            // rbtn15yr
            // 
            this.rbtn15yr.AutoSize = true;
            this.rbtn15yr.Checked = true;
            this.rbtn15yr.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rbtn15yr.Location = new System.Drawing.Point(51, 171);
            this.rbtn15yr.Name = "rbtn15yr";
            this.rbtn15yr.Size = new System.Drawing.Size(85, 17);
            this.rbtn15yr.TabIndex = 29;
            this.rbtn15yr.TabStop = true;
            this.rbtn15yr.Text = "15 year loan";
            this.rbtn15yr.UseVisualStyleBackColor = true;
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblIncome.Location = new System.Drawing.Point(53, 138);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(83, 13);
            this.lblIncome.TabIndex = 27;
            this.lblIncome.Text = "Income (Yearly)";
            // 
            // lblIncomeErr
            // 
            this.lblIncomeErr.AutoSize = true;
            this.lblIncomeErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblIncomeErr.ForeColor = System.Drawing.Color.Red;
            this.lblIncomeErr.Location = new System.Drawing.Point(37, 138);
            this.lblIncomeErr.Name = "lblIncomeErr";
            this.lblIncomeErr.Size = new System.Drawing.Size(11, 13);
            this.lblIncomeErr.TabIndex = 28;
            this.lblIncomeErr.Text = "!";
            this.lblIncomeErr.Visible = false;
            // 
            // lblRateErr
            // 
            this.lblRateErr.AutoSize = true;
            this.lblRateErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblRateErr.ForeColor = System.Drawing.Color.Red;
            this.lblRateErr.Location = new System.Drawing.Point(37, 97);
            this.lblRateErr.Name = "lblRateErr";
            this.lblRateErr.Size = new System.Drawing.Size(11, 13);
            this.lblRateErr.TabIndex = 23;
            this.lblRateErr.Text = "!";
            this.lblRateErr.Visible = false;
            // 
            // lblScoreErr
            // 
            this.lblScoreErr.AutoSize = true;
            this.lblScoreErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblScoreErr.ForeColor = System.Drawing.Color.Red;
            this.lblScoreErr.Location = new System.Drawing.Point(37, 59);
            this.lblScoreErr.Name = "lblScoreErr";
            this.lblScoreErr.Size = new System.Drawing.Size(11, 13);
            this.lblScoreErr.TabIndex = 22;
            this.lblScoreErr.Text = "!";
            this.lblScoreErr.Visible = false;
            // 
            // lblValueErr
            // 
            this.lblValueErr.AutoSize = true;
            this.lblValueErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblValueErr.ForeColor = System.Drawing.Color.Red;
            this.lblValueErr.Location = new System.Drawing.Point(37, 19);
            this.lblValueErr.Name = "lblValueErr";
            this.lblValueErr.Size = new System.Drawing.Size(11, 13);
            this.lblValueErr.TabIndex = 21;
            this.lblValueErr.Text = "!";
            this.lblValueErr.Visible = false;
            // 
            // tbxValue
            // 
            this.tbxValue.Location = new System.Drawing.Point(139, 16);
            this.tbxValue.Name = "tbxValue";
            this.tbxValue.Size = new System.Drawing.Size(100, 20);
            this.tbxValue.TabIndex = 1;
            // 
            // tbxRate
            // 
            this.tbxRate.Location = new System.Drawing.Point(139, 94);
            this.tbxRate.Name = "tbxRate";
            this.tbxRate.Size = new System.Drawing.Size(100, 20);
            this.tbxRate.TabIndex = 17;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblRate.Location = new System.Drawing.Point(53, 97);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(72, 13);
            this.lblRate.TabIndex = 18;
            this.lblRate.Text = "Interest Rate";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblValue.Location = new System.Drawing.Point(53, 19);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(59, 13);
            this.lblValue.TabIndex = 2;
            this.lblValue.Text = "Loan Value";
            // 
            // tbxScore
            // 
            this.tbxScore.Location = new System.Drawing.Point(139, 56);
            this.tbxScore.Name = "tbxScore";
            this.tbxScore.Size = new System.Drawing.Size(100, 20);
            this.tbxScore.TabIndex = 3;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblScore.Location = new System.Drawing.Point(53, 59);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(66, 13);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Credit Score";
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.BackColor = System.Drawing.Color.Coral;
            this.lblTitle1.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle1.Location = new System.Drawing.Point(77, 12);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Padding = new System.Windows.Forms.Padding(3);
            this.lblTitle1.Size = new System.Drawing.Size(233, 27);
            this.lblTitle1.TabIndex = 0;
            this.lblTitle1.Text = "Mortgage Rate Calculator";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(7, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 387);
            this.panel2.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
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
            this.tpgCalc.Location = new System.Drawing.Point(4, 25);
            this.tpgCalc.Name = "tpgCalc";
            this.tpgCalc.Padding = new System.Windows.Forms.Padding(3);
            this.tpgCalc.Size = new System.Drawing.Size(777, 406);
            this.tpgCalc.TabIndex = 1;
            this.tpgCalc.Text = "Calculation";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.panel6);
            this.panel7.Controls.Add(this.lblTitle2);
            this.panel7.Location = new System.Drawing.Point(196, 16);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(384, 387);
            this.panel7.TabIndex = 20;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel8.Controls.Add(this.btnRetry);
            this.panel8.Controls.Add(this.btnReroll);
            this.panel8.Controls.Add(this.btnQuit);
            this.panel8.Location = new System.Drawing.Point(25, 273);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(332, 66);
            this.panel8.TabIndex = 13;
            // 
            // btnRetry
            // 
            this.btnRetry.BackColor = System.Drawing.Color.Red;
            this.btnRetry.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.btnRetry.FlatAppearance.BorderSize = 3;
            this.btnRetry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetry.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnRetry.ForeColor = System.Drawing.Color.White;
            this.btnRetry.Location = new System.Drawing.Point(98, 18);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(113, 28);
            this.btnRetry.TabIndex = 13;
            this.btnRetry.Text = "Calculate again";
            this.btnRetry.UseVisualStyleBackColor = false;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // btnReroll
            // 
            this.btnReroll.BackColor = System.Drawing.Color.Red;
            this.btnReroll.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.btnReroll.FlatAppearance.BorderSize = 3;
            this.btnReroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReroll.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnReroll.ForeColor = System.Drawing.Color.White;
            this.btnReroll.Location = new System.Drawing.Point(12, 18);
            this.btnReroll.Name = "btnReroll";
            this.btnReroll.Size = new System.Drawing.Size(80, 28);
            this.btnReroll.TabIndex = 12;
            this.btnReroll.Text = "Start over";
            this.btnReroll.UseVisualStyleBackColor = false;
            this.btnReroll.Click += new System.EventHandler(this.btnReroll_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Red;
            this.btnQuit.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.btnQuit.FlatAppearance.BorderSize = 3;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.Location = new System.Drawing.Point(231, 18);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 28);
            this.btnQuit.TabIndex = 11;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel6.Controls.Add(this.pnlCost);
            this.panel6.Controls.Add(this.pnlMonth);
            this.panel6.Controls.Add(this.pnlRate);
            this.panel6.Location = new System.Drawing.Point(25, 58);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(332, 184);
            this.panel6.TabIndex = 0;
            // 
            // pnlCost
            // 
            this.pnlCost.BackColor = System.Drawing.Color.White;
            this.pnlCost.Controls.Add(this.lblCostInfo);
            this.pnlCost.Controls.Add(this.lblCost);
            this.pnlCost.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pnlCost.Location = new System.Drawing.Point(0, 23);
            this.pnlCost.Name = "pnlCost";
            this.pnlCost.Size = new System.Drawing.Size(332, 34);
            this.pnlCost.TabIndex = 7;
            // 
            // lblCostInfo
            // 
            this.lblCostInfo.AutoSize = true;
            this.lblCostInfo.Location = new System.Drawing.Point(69, 10);
            this.lblCostInfo.Name = "lblCostInfo";
            this.lblCostInfo.Size = new System.Drawing.Size(131, 13);
            this.lblCostInfo.TabIndex = 1;
            this.lblCostInfo.Text = "Total Cost (With Interest)";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblCost.Location = new System.Drawing.Point(228, 10);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(45, 13);
            this.lblCost.TabIndex = 4;
            this.lblCost.Text = "$0,000";
            // 
            // pnlMonth
            // 
            this.pnlMonth.BackColor = System.Drawing.Color.White;
            this.pnlMonth.Controls.Add(this.lblPaymentInfo);
            this.pnlMonth.Controls.Add(this.lblPayment);
            this.pnlMonth.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pnlMonth.Location = new System.Drawing.Point(0, 73);
            this.pnlMonth.Name = "pnlMonth";
            this.pnlMonth.Size = new System.Drawing.Size(332, 35);
            this.pnlMonth.TabIndex = 8;
            // 
            // lblPaymentInfo
            // 
            this.lblPaymentInfo.AutoSize = true;
            this.lblPaymentInfo.Location = new System.Drawing.Point(69, 11);
            this.lblPaymentInfo.Name = "lblPaymentInfo";
            this.lblPaymentInfo.Size = new System.Drawing.Size(90, 13);
            this.lblPaymentInfo.TabIndex = 1;
            this.lblPaymentInfo.Text = "Monthly Payment";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPayment.Location = new System.Drawing.Point(228, 11);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(35, 13);
            this.lblPayment.TabIndex = 4;
            this.lblPayment.Text = "$100";
            // 
            // pnlRate
            // 
            this.pnlRate.BackColor = System.Drawing.Color.White;
            this.pnlRate.Controls.Add(this.lblInterestInfo);
            this.pnlRate.Controls.Add(this.lblInterest);
            this.pnlRate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pnlRate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlRate.Location = new System.Drawing.Point(0, 124);
            this.pnlRate.Name = "pnlRate";
            this.pnlRate.Size = new System.Drawing.Size(332, 34);
            this.pnlRate.TabIndex = 10;
            // 
            // lblInterestInfo
            // 
            this.lblInterestInfo.AutoSize = true;
            this.lblInterestInfo.Location = new System.Drawing.Point(69, 10);
            this.lblInterestInfo.Name = "lblInterestInfo";
            this.lblInterestInfo.Size = new System.Drawing.Size(109, 13);
            this.lblInterestInfo.TabIndex = 1;
            this.lblInterestInfo.Text = "Interest Rate (Fixed)";
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblInterest.Location = new System.Drawing.Point(228, 10);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(37, 13);
            this.lblInterest.TabIndex = 4;
            this.lblInterest.Text = "1.0%";
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.BackColor = System.Drawing.Color.Coral;
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
            this.sideblock2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sideblock2.BackgroundImage")));
            this.sideblock2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sideblock2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sideblock2.Location = new System.Drawing.Point(586, 16);
            this.sideblock2.Name = "sideblock2";
            this.sideblock2.Size = new System.Drawing.Size(184, 387);
            this.sideblock2.TabIndex = 19;
            // 
            // sideblock1
            // 
            this.sideblock1.BackColor = System.Drawing.Color.Crimson;
            this.sideblock1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sideblock1.BackgroundImage")));
            this.sideblock1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
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
            this.Text = "Mortgage Rate Calculator";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tpgData.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tpgCalc.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.pnlCost.ResumeLayout(false);
            this.pnlCost.PerformLayout();
            this.pnlMonth.ResumeLayout(false);
            this.pnlMonth.PerformLayout();
            this.pnlRate.ResumeLayout(false);
            this.pnlRate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpgData;
        private System.Windows.Forms.TabPage tpgCalc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblScore;
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
        private System.Windows.Forms.TextBox tbxRate;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblRateErr;
        private System.Windows.Forms.Label lblScoreErr;
        private System.Windows.Forms.Label lblValueErr;
        private System.Windows.Forms.RadioButton rbtn30yr;
        private System.Windows.Forms.TextBox tbxIncome;
        private System.Windows.Forms.RadioButton rbtn15yr;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.Label lblIncomeErr;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnRetry;
    }

}

