using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Kalkulator22_2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }



        private void buttonMRC_Clicked(object sender, EventArgs e)
        { 

        }

        private void buttonMSubtraction_Clicked(object sender, EventArgs e)
        {
             
        }

        private void buttonMAddition_Clicked(object sender, EventArgs e)
        {

        }



 
        private void button0_Clicked(object sender, EventArgs e)
        {
            labelDisplay0.Text += "0";
        }

        private void button1_Clicked(object sender, EventArgs e)
        {
            labelDisplay0.Text += "1";
        }

        private void button2_Clicked(object sender, EventArgs e)
        {
            labelDisplay0.Text += "2";
        }

        private void button3_Clicked(object sender, EventArgs e)
        {
            labelDisplay0.Text += "3";
        }

        private void button4_Clicked(object sender, EventArgs e)
        {
            labelDisplay0.Text += "4";
        }

        private void button5_Clicked(object sender, EventArgs e)
        {
            labelDisplay0.Text += "5";
        }

        private void button6_Clicked(object sender, EventArgs e)
        {
            labelDisplay0.Text += "6";
        }

        private void button7_Clicked(object sender, EventArgs e)
        {
            labelDisplay0.Text += "7";
        }

        private void button8_Clicked(object sender, EventArgs e)
        {
            labelDisplay0.Text += "8";
        }

        private void button9_Clicked(object sender, EventArgs e)
        {
            labelDisplay0.Text += "9";
        }

        private void buttonDot_Clicked(object sender, EventArgs e)
        {
            labelDisplay0.Text += ".";
        }

        private void buttonAddition_Clicked(object sender, EventArgs e)
        {
            labelDisplay0.Text += "+";
        }

        private void buttonSubtraction_Clicked(object sender, EventArgs e)
        {
            labelDisplay0.Text += "-";
        }

        private void buttonMultiplication_Clicked(object sender, EventArgs e)
        {
            labelDisplay0.Text += "*";
        }

        private void buttonDivide_Clicked(object sender, EventArgs e)
        {
            labelDisplay0.Text += "/";
        }

        private void ButtonCE_Clicked(object sender, EventArgs e)
        {
            labelDisplay0.Text = "";
           
        }

        private void buttonDeleteSign_Clicked(object sender, EventArgs e)
        {
            if (labelDisplay0.Text.Length >0)
                labelDisplay0.Text = 
                    labelDisplay0.Text.Substring(0, labelDisplay0.Text.Length - 1);
        }






        private void buttonEqual_Clicked(object sender, EventArgs e)
        {
            string s1="";

            String[] separatorOperation = {"+", "-", "*", "/", "(", ")" };
            String[] number = labelDisplay0.Text.Split(separatorOperation, StringSplitOptions.None);



            foreach (String s2 in number)
            {
                s1 += s2 + " ";
            }

           // var listDigit = new List<double> { };



            labelDisplay1.Text = s1;

        }

        private void buttonF_Clicked(object sender, EventArgs e)
        {

        }

        private void buttonBracketLeft_Clicked(object sender, EventArgs e)
        {

        }

        private void buttonBracketRight_Clicked(object sender, EventArgs e)
        {

        }


    }
}
