using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Credit_Card_Validation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Global Variables

        string[] cardTypes = new string[] { "Visa", "MasterCard", "AmericanExpress", "Discover", "DinersClub" };

        #endregion

        #region Event Handler
        private void AcceptsOnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void VerifyButton_Click(object sender, EventArgs e)
        {
            int typeOfCard = CardType(inputTextBox.Text);
            bool checkSumDivisibleBy10 = CheckSum(inputTextBox.Text);

            if (typeOfCard >=0 && checkSumDivisibleBy10==true)
            {
                IsValidLabel.Text = "The credit card number is valid";
                cardTypeLabel.Text = "The type of card is: " + cardTypes[typeOfCard];

            }
            else
            {
                IsValidLabel.Text = "The credit card number is not valid";
            }
                
        }

        private void VisaButton_Click(object sender, EventArgs e)
        {
            Random randomGenerator = new Random();
            string[] visaNumber = new string[16];
            visaNumber[0] = "4";

            for (int i=1; i<15; i++)
            {
                visaNumber[i] = randomGenerator.Next(1, 10).ToString();
            }
            visaNumber[15] = "0";

            string cardNumber = "";

            for (int i=0; i<16; i++)
            {
                cardNumber += visaNumber[i];
            }

            visaNumber[15] = LastDigit(cardNumber);

            cardNumber = "";

            for (int i = 0; i < 16; i++)
            {
                cardNumber += visaNumber[i];
            }

            generatedCreditCardNumberLabel.Text = cardNumber;            
        }

        private void MasterCardButton_Click(object sender, EventArgs e)
        {
            Random randomGenerator = new Random();
            string[] masterCardNumber = new string[16];
            masterCardNumber[0] = "5";
            string[] cardDigit = new string[2] { "1", "5" };

            masterCardNumber[1] = cardDigit[randomGenerator.Next(0, 2)];

            for (int i = 2; i < 15; i++)
            {
                masterCardNumber[i] = randomGenerator.Next(1, 10).ToString();
            }
            masterCardNumber[15] = "0";

            string cardNumber = "";

            for (int i = 0; i < 16; i++)
            {
                cardNumber += masterCardNumber[i];
            }

            masterCardNumber[15] = LastDigit(cardNumber);

            cardNumber = "";

            for (int i = 0; i < 16; i++)
            {
                cardNumber += masterCardNumber[i];
            }

            generatedCreditCardNumberLabel.Text = cardNumber;
        }

        private void DiscoverButton_Click(object sender, EventArgs e)
        {
            Random randomGenerator = new Random();
            string[] discoverNumber = new string[16];
            discoverNumber[0] = "6";
            discoverNumber[1] = "0";
            discoverNumber[2] = "1";
            discoverNumber[3] = "1";
 
            for (int i = 4; i < 15; i++)
            {
                discoverNumber[i] = randomGenerator.Next(1, 10).ToString();
            }
            discoverNumber[15] = "0";

            string cardNumber = "";

            for (int i = 0; i < 16; i++)
            {
                cardNumber += discoverNumber[i];
            }

            discoverNumber[15] = LastDigit(cardNumber);

            cardNumber = "";

            for (int i = 0; i < 16; i++)
            {
                cardNumber += discoverNumber[i];
            }

            generatedCreditCardNumberLabel.Text = cardNumber;
        }

        private void DinersClubButton_Click(object sender, EventArgs e)
        {
            Random randomGenerator = new Random();
            string[] dinersClubNumber = new string[14];
            dinersClubNumber[0] = "3";
            dinersClubNumber[1] = "6";

            for (int i = 2; i < 13; i++)
            {
                dinersClubNumber[i] = randomGenerator.Next(1, 10).ToString();
            }
            dinersClubNumber[13] = "0";

            string cardNumber = "";

            for (int i = 0; i < 14; i++)
            {
                cardNumber += dinersClubNumber[i];
            }

            dinersClubNumber[13] = LastDigit(cardNumber);

            cardNumber = "";

            for (int i = 0; i < 14; i++)
            {
                cardNumber += dinersClubNumber[i];
            }

            generatedCreditCardNumberLabel.Text = cardNumber;
        }

        private void AmericanExpressButton_Click(object sender, EventArgs e)
        {
            Random randomGenerator = new Random();
            string[] americanExpress = new string[15];
            americanExpress[0] = "3";
            string[] cardDigit = new string[2] { "4", "7" };

            americanExpress[1] = cardDigit[randomGenerator.Next(0, 2)];

            for (int i = 2; i < 14; i++)
            {
                americanExpress[i] = randomGenerator.Next(1, 10).ToString();
            }
            americanExpress[14] = "0";

            string cardNumber = "";

            for (int i = 0; i < 15; i++)
            {
                cardNumber += americanExpress[i];
            }

            americanExpress[14] = LastDigit(cardNumber);

            cardNumber = "";

            for (int i = 0; i < 15; i++)
            {
                cardNumber += americanExpress[i];
            }

            generatedCreditCardNumberLabel.Text = cardNumber;
        }
    
        #endregion

        #region Methods

        private static int CardType (string creditCardDigits)
        {
            
            int numberOfDigits= creditCardDigits.Length;
            int card = -1;
            string firstTwoDigits = creditCardDigits.Substring(0, 2);

            if (numberOfDigits == 16)
            {                

                if (creditCardDigits.Substring(0, 1) == "4")
                {
                    card = 0;                    
                }
                
                else if (firstTwoDigits == "51" || firstTwoDigits == "55")
                {
                    card = 1;
                }

                else if (creditCardDigits.Substring(0,4)=="6011")
                {
                    card = 3;
                }
                else
                {
                    card = -1;
                }

            }
            else if (numberOfDigits==15)
            {
                if (firstTwoDigits == "34" || firstTwoDigits == "37")
                {
                    card = 2;
                }
                else card = -1;
            }     
       
            else if (numberOfDigits==14)
            {
                if (firstTwoDigits == "36")
                {
                    card = 4;
                }
                else
                {
                    card = -1;
                }
            }
            else
            {
                card = -1;
            }

            return card;

        }

        private static bool CheckSum (string creditCardDigits)
        {
            int sum = 0;

            for (int i = creditCardDigits.Length - 1; i > 0; i-=2 )
            {
                int oddDigit = Convert.ToInt32(creditCardDigits.Substring(i, 1));
                int evenDigit = Convert.ToInt32(creditCardDigits.Substring(i-1, 1));

                sum += oddDigit;
             
                int product = evenDigit * 2;
                if (product <= 9)
                {
                    sum += product;
                }
                else
                {
                    sum += (product / 10 + product % 10);
                }                           
                
            }
            if (sum%10==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static string LastDigit(string creditCardDigits)
        {
            int sum = 0;

            for (int i = creditCardDigits.Length - 1; i > 0; i -= 2)
            {
                int oddDigit = Convert.ToInt32(creditCardDigits.Substring(i, 1));
                int evenDigit = Convert.ToInt32(creditCardDigits.Substring(i - 1, 1));

                sum += oddDigit;

                int product = evenDigit * 2;
                if (product <= 9)
                {
                    sum += product;
                }
                else
                {
                    sum += (product / 10 + product % 10);
                }

            }
            return (10-(sum % 10)).ToString();
        }






        #endregion

        
    }
}
