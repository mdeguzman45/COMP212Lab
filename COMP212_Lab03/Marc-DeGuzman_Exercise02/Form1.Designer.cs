
namespace Marc_DeGuzman_Exercise02
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.asyncGroupBox = new System.Windows.Forms.GroupBox();
            this.carLoanGroupBox = new System.Windows.Forms.GroupBox();
            this.factorialLabel = new System.Windows.Forms.Label();
            this.factorialTextBox = new System.Windows.Forms.TextBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.factorialOutputLabel = new System.Windows.Forms.Label();
            this.loanAmountLabel = new System.Windows.Forms.Label();
            this.interestRateLabel = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.loanAmountTextBox = new System.Windows.Forms.TextBox();
            this.interestRateTextBox = new System.Windows.Forms.TextBox();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.calcInterestBtn = new System.Windows.Forms.Button();
            this.interestRateOutputLabel = new System.Windows.Forms.Label();
            this.asyncGroupBox.SuspendLayout();
            this.carLoanGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // asyncGroupBox
            // 
            this.asyncGroupBox.Controls.Add(this.factorialOutputLabel);
            this.asyncGroupBox.Controls.Add(this.calculateBtn);
            this.asyncGroupBox.Controls.Add(this.factorialTextBox);
            this.asyncGroupBox.Controls.Add(this.factorialLabel);
            this.asyncGroupBox.Location = new System.Drawing.Point(13, 22);
            this.asyncGroupBox.Name = "asyncGroupBox";
            this.asyncGroupBox.Size = new System.Drawing.Size(308, 203);
            this.asyncGroupBox.TabIndex = 0;
            this.asyncGroupBox.TabStop = false;
            this.asyncGroupBox.Text = "Calculate Asynchronously";
            // 
            // carLoanGroupBox
            // 
            this.carLoanGroupBox.Controls.Add(this.interestRateOutputLabel);
            this.carLoanGroupBox.Controls.Add(this.calcInterestBtn);
            this.carLoanGroupBox.Controls.Add(this.durationTextBox);
            this.carLoanGroupBox.Controls.Add(this.interestRateTextBox);
            this.carLoanGroupBox.Controls.Add(this.loanAmountTextBox);
            this.carLoanGroupBox.Controls.Add(this.durationLabel);
            this.carLoanGroupBox.Controls.Add(this.interestRateLabel);
            this.carLoanGroupBox.Controls.Add(this.loanAmountLabel);
            this.carLoanGroupBox.Location = new System.Drawing.Point(339, 22);
            this.carLoanGroupBox.Name = "carLoanGroupBox";
            this.carLoanGroupBox.Size = new System.Drawing.Size(415, 203);
            this.carLoanGroupBox.TabIndex = 1;
            this.carLoanGroupBox.TabStop = false;
            this.carLoanGroupBox.Text = "Car Loan Calculator";
            // 
            // factorialLabel
            // 
            this.factorialLabel.AutoSize = true;
            this.factorialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factorialLabel.Location = new System.Drawing.Point(6, 35);
            this.factorialLabel.Name = "factorialLabel";
            this.factorialLabel.Size = new System.Drawing.Size(109, 17);
            this.factorialLabel.TabIndex = 0;
            this.factorialLabel.Text = "Get Factorial of:";
            // 
            // factorialTextBox
            // 
            this.factorialTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factorialTextBox.Location = new System.Drawing.Point(138, 35);
            this.factorialTextBox.Name = "factorialTextBox";
            this.factorialTextBox.Size = new System.Drawing.Size(152, 23);
            this.factorialTextBox.TabIndex = 1;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateBtn.Location = new System.Drawing.Point(85, 78);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(109, 27);
            this.calculateBtn.TabIndex = 2;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // factorialOutputLabel
            // 
            this.factorialOutputLabel.AutoEllipsis = true;
            this.factorialOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.factorialOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factorialOutputLabel.Location = new System.Drawing.Point(9, 131);
            this.factorialOutputLabel.Name = "factorialOutputLabel";
            this.factorialOutputLabel.Size = new System.Drawing.Size(281, 26);
            this.factorialOutputLabel.TabIndex = 3;
            this.factorialOutputLabel.Text = "Factorial Result";
            // 
            // loanAmountLabel
            // 
            this.loanAmountLabel.AutoSize = true;
            this.loanAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanAmountLabel.Location = new System.Drawing.Point(33, 35);
            this.loanAmountLabel.Name = "loanAmountLabel";
            this.loanAmountLabel.Size = new System.Drawing.Size(96, 17);
            this.loanAmountLabel.TabIndex = 0;
            this.loanAmountLabel.Text = "Loan Amount:";
            // 
            // interestRateLabel
            // 
            this.interestRateLabel.AutoSize = true;
            this.interestRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestRateLabel.Location = new System.Drawing.Point(33, 78);
            this.interestRateLabel.Name = "interestRateLabel";
            this.interestRateLabel.Size = new System.Drawing.Size(93, 17);
            this.interestRateLabel.TabIndex = 1;
            this.interestRateLabel.Text = "Interest Rate:";
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationLabel.Location = new System.Drawing.Point(33, 117);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(115, 17);
            this.durationLabel.TabIndex = 2;
            this.durationLabel.Text = "Duration [Years]:";
            // 
            // loanAmountTextBox
            // 
            this.loanAmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanAmountTextBox.Location = new System.Drawing.Point(154, 32);
            this.loanAmountTextBox.Name = "loanAmountTextBox";
            this.loanAmountTextBox.Size = new System.Drawing.Size(118, 23);
            this.loanAmountTextBox.TabIndex = 3;
            // 
            // interestRateTextBox
            // 
            this.interestRateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestRateTextBox.Location = new System.Drawing.Point(154, 75);
            this.interestRateTextBox.Name = "interestRateTextBox";
            this.interestRateTextBox.Size = new System.Drawing.Size(118, 23);
            this.interestRateTextBox.TabIndex = 4;
            // 
            // durationTextBox
            // 
            this.durationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationTextBox.Location = new System.Drawing.Point(154, 114);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(118, 23);
            this.durationTextBox.TabIndex = 5;
            // 
            // calcInterestBtn
            // 
            this.calcInterestBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcInterestBtn.Location = new System.Drawing.Point(300, 59);
            this.calcInterestBtn.Name = "calcInterestBtn";
            this.calcInterestBtn.Size = new System.Drawing.Size(109, 65);
            this.calcInterestBtn.TabIndex = 6;
            this.calcInterestBtn.Text = "Calculate Interest";
            this.calcInterestBtn.UseVisualStyleBackColor = true;
            this.calcInterestBtn.Click += new System.EventHandler(this.calcInterestBtn_Click);
            // 
            // interestRateOutputLabel
            // 
            this.interestRateOutputLabel.AutoSize = true;
            this.interestRateOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.interestRateOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestRateOutputLabel.Location = new System.Drawing.Point(33, 161);
            this.interestRateOutputLabel.Name = "interestRateOutputLabel";
            this.interestRateOutputLabel.Size = new System.Drawing.Size(130, 19);
            this.interestRateOutputLabel.TabIndex = 7;
            this.interestRateOutputLabel.Text = "Interest Calculation";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 257);
            this.Controls.Add(this.carLoanGroupBox);
            this.Controls.Add(this.asyncGroupBox);
            this.Name = "mainForm";
            this.Text = "Asynchronous Programming";
            this.asyncGroupBox.ResumeLayout(false);
            this.asyncGroupBox.PerformLayout();
            this.carLoanGroupBox.ResumeLayout(false);
            this.carLoanGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox asyncGroupBox;
        private System.Windows.Forms.Label factorialOutputLabel;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.TextBox factorialTextBox;
        private System.Windows.Forms.Label factorialLabel;
        private System.Windows.Forms.GroupBox carLoanGroupBox;
        private System.Windows.Forms.Label interestRateOutputLabel;
        private System.Windows.Forms.Button calcInterestBtn;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.TextBox interestRateTextBox;
        private System.Windows.Forms.TextBox loanAmountTextBox;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.Label interestRateLabel;
        private System.Windows.Forms.Label loanAmountLabel;
    }
}

