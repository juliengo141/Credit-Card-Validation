namespace Credit_Card_Validation
{
    partial class Form1
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.verifyButton = new System.Windows.Forms.Button();
            this.IsValidLabel = new System.Windows.Forms.Label();
            this.cardTypeLabel = new System.Windows.Forms.Label();
            this.VisaButton = new System.Windows.Forms.Button();
            this.MasterCardButton = new System.Windows.Forms.Button();
            this.AmericanExpressButton = new System.Windows.Forms.Button();
            this.DiscoverButton = new System.Windows.Forms.Button();
            this.DinersClubButton = new System.Windows.Forms.Button();
            this.creditCardGeneratorLabel = new System.Windows.Forms.Label();
            this.creditCardNumberIsLabel = new System.Windows.Forms.Label();
            this.generatedCreditCardNumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(28, 28);
            this.inputTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.inputTextBox.MaxLength = 16;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(175, 22);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AcceptsOnlyNumbers_KeyPress);
            // 
            // verifyButton
            // 
            this.verifyButton.Location = new System.Drawing.Point(231, 28);
            this.verifyButton.Margin = new System.Windows.Forms.Padding(4);
            this.verifyButton.Name = "verifyButton";
            this.verifyButton.Size = new System.Drawing.Size(100, 28);
            this.verifyButton.TabIndex = 1;
            this.verifyButton.Text = "Verify";
            this.verifyButton.UseVisualStyleBackColor = true;
            this.verifyButton.Click += new System.EventHandler(this.VerifyButton_Click);
            // 
            // IsValidLabel
            // 
            this.IsValidLabel.AutoSize = true;
            this.IsValidLabel.Location = new System.Drawing.Point(24, 73);
            this.IsValidLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IsValidLabel.Name = "IsValidLabel";
            this.IsValidLabel.Size = new System.Drawing.Size(178, 17);
            this.IsValidLabel.TabIndex = 2;
            this.IsValidLabel.Text = "The credit card number is :";
            // 
            // cardTypeLabel
            // 
            this.cardTypeLabel.AutoSize = true;
            this.cardTypeLabel.Location = new System.Drawing.Point(24, 95);
            this.cardTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cardTypeLabel.Name = "cardTypeLabel";
            this.cardTypeLabel.Size = new System.Drawing.Size(98, 17);
            this.cardTypeLabel.TabIndex = 3;
            this.cardTypeLabel.Text = "Type of Card :";
            // 
            // VisaButton
            // 
            this.VisaButton.Location = new System.Drawing.Point(29, 161);
            this.VisaButton.Name = "VisaButton";
            this.VisaButton.Size = new System.Drawing.Size(88, 23);
            this.VisaButton.TabIndex = 4;
            this.VisaButton.Text = "Visa";
            this.VisaButton.UseVisualStyleBackColor = true;
            this.VisaButton.Click += new System.EventHandler(this.VisaButton_Click);
            // 
            // MasterCardButton
            // 
            this.MasterCardButton.Location = new System.Drawing.Point(132, 161);
            this.MasterCardButton.Name = "MasterCardButton";
            this.MasterCardButton.Size = new System.Drawing.Size(93, 23);
            this.MasterCardButton.TabIndex = 5;
            this.MasterCardButton.Text = "Master Card";
            this.MasterCardButton.UseVisualStyleBackColor = true;
            this.MasterCardButton.Click += new System.EventHandler(this.MasterCardButton_Click);
            // 
            // AmericanExpressButton
            // 
            this.AmericanExpressButton.Location = new System.Drawing.Point(189, 195);
            this.AmericanExpressButton.Name = "AmericanExpressButton";
            this.AmericanExpressButton.Size = new System.Drawing.Size(142, 23);
            this.AmericanExpressButton.TabIndex = 6;
            this.AmericanExpressButton.Text = "American Express";
            this.AmericanExpressButton.UseVisualStyleBackColor = true;
            this.AmericanExpressButton.Click += new System.EventHandler(this.AmericanExpressButton_Click);
            // 
            // DiscoverButton
            // 
            this.DiscoverButton.Location = new System.Drawing.Point(239, 161);
            this.DiscoverButton.Name = "DiscoverButton";
            this.DiscoverButton.Size = new System.Drawing.Size(92, 23);
            this.DiscoverButton.TabIndex = 7;
            this.DiscoverButton.Text = "Discover";
            this.DiscoverButton.UseVisualStyleBackColor = true;
            this.DiscoverButton.Click += new System.EventHandler(this.DiscoverButton_Click);
            // 
            // DinersClubButton
            // 
            this.DinersClubButton.Location = new System.Drawing.Point(27, 195);
            this.DinersClubButton.Name = "DinersClubButton";
            this.DinersClubButton.Size = new System.Drawing.Size(144, 23);
            this.DinersClubButton.TabIndex = 8;
            this.DinersClubButton.Text = "Diners Club";
            this.DinersClubButton.UseVisualStyleBackColor = true;
            this.DinersClubButton.Click += new System.EventHandler(this.DinersClubButton_Click);
            // 
            // creditCardGeneratorLabel
            // 
            this.creditCardGeneratorLabel.AutoSize = true;
            this.creditCardGeneratorLabel.Location = new System.Drawing.Point(26, 133);
            this.creditCardGeneratorLabel.Name = "creditCardGeneratorLabel";
            this.creditCardGeneratorLabel.Size = new System.Drawing.Size(234, 17);
            this.creditCardGeneratorLabel.TabIndex = 10;
            this.creditCardGeneratorLabel.Text = "Generate a Credit Card Number for:";
            // 
            // creditCardNumberIsLabel
            // 
            this.creditCardNumberIsLabel.AutoSize = true;
            this.creditCardNumberIsLabel.Location = new System.Drawing.Point(29, 232);
            this.creditCardNumberIsLabel.Name = "creditCardNumberIsLabel";
            this.creditCardNumberIsLabel.Size = new System.Drawing.Size(174, 17);
            this.creditCardNumberIsLabel.TabIndex = 11;
            this.creditCardNumberIsLabel.Text = "The credit card number is:";
            // 
            // generatedCreditCardNumberLabel
            // 
            this.generatedCreditCardNumberLabel.AutoSize = true;
            this.generatedCreditCardNumberLabel.Location = new System.Drawing.Point(32, 253);
            this.generatedCreditCardNumberLabel.Name = "generatedCreditCardNumberLabel";
            this.generatedCreditCardNumberLabel.Size = new System.Drawing.Size(0, 17);
            this.generatedCreditCardNumberLabel.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 292);
            this.Controls.Add(this.generatedCreditCardNumberLabel);
            this.Controls.Add(this.creditCardNumberIsLabel);
            this.Controls.Add(this.creditCardGeneratorLabel);
            this.Controls.Add(this.DinersClubButton);
            this.Controls.Add(this.DiscoverButton);
            this.Controls.Add(this.AmericanExpressButton);
            this.Controls.Add(this.MasterCardButton);
            this.Controls.Add(this.VisaButton);
            this.Controls.Add(this.cardTypeLabel);
            this.Controls.Add(this.IsValidLabel);
            this.Controls.Add(this.verifyButton);
            this.Controls.Add(this.inputTextBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Credit Card Validation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button verifyButton;
        private System.Windows.Forms.Label IsValidLabel;
        private System.Windows.Forms.Label cardTypeLabel;
        private System.Windows.Forms.Button VisaButton;
        private System.Windows.Forms.Button MasterCardButton;
        private System.Windows.Forms.Button AmericanExpressButton;
        private System.Windows.Forms.Button DiscoverButton;
        private System.Windows.Forms.Button DinersClubButton;
        private System.Windows.Forms.Label creditCardGeneratorLabel;
        private System.Windows.Forms.Label creditCardNumberIsLabel;
        private System.Windows.Forms.Label generatedCreditCardNumberLabel;
    }
}

