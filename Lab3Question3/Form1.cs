using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//a program that counts vowels in a string inutted by user and counts number of non-vowels
namespace Lab3Question3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
   
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //convert string to uppercase(easier to find vowels)
            string input = txtString.Text.ToUpper();
            int vowelCount = 0;
            int otherCount = 0;
            //scan each char in string 
            
            foreach (char a in input)
            {
                //call function to check if the text box is empty
                validate();
                //call function that passes in char and returns true if char is vowel
                //or false if non-vowel
                bool isVowel = isVowelPresent(a);
                if (isVowel == true)
                {
                    //if returns true incremnt vowelCounter by 1
                    vowelCount++;
                }
                else
                    //otherwise increment otherCount by 1
                    otherCount++;
            }
            txtVowel.Text = vowelCount.ToString();
            txtOther.Text = otherCount.ToString();
        }

        //declaration of function to return true if vowel is present or false if not
        bool isVowelPresent(char v)
        {
            if (v == 'A' || v == 'E' || v == 'I' || v == 'O' || v == 'U')
            {
                return true;
            }
            else return false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close form when exit button clicked
            this.Close();
        }
        //declaration of function to check if emtpy
        void validate()
        {
            if (txtString.Text == "")
            {
                MessageBox.Show(
                    "Please enter a sentence. Space must not be empty", "Error!");
                this.Close();
            }
        }
    }
}
