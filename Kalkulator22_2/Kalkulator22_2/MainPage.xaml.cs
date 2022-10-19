using Kalkulator22_2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
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



        private void ButtonMRC_Clicked(object sender, EventArgs e)
        { 

        }

        private void ButtonMSubtraction_Clicked(object sender, EventArgs e)
        {
             
        }

        private void ButtonMAddition_Clicked(object sender, EventArgs e)
        {

        }



 
        private void Button0_Clicked(object sender, EventArgs e)
        {
            labelDisplay0.Text += "0";
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            labelDisplay0.Text += "1";
        }

        private void Button2_Clicked(object sender, EventArgs e)
        {
            labelDisplay0.Text += "2";
        }

        private void Button3_Clicked(object sender, EventArgs e)
        {
            labelDisplay0.Text += "3";
        }

        private void Button4_Clicked(object sender, EventArgs e)
        {
            labelDisplay0.Text += "4";
        }

        private void Button5_Clicked(object sender, EventArgs e)
        {
            labelDisplay0.Text += "5";
        }

        private void Button6_Clicked(object sender, EventArgs e)
        {
            labelDisplay0.Text += "6";
        }

        private void Button7_Clicked(object sender, EventArgs e)
        {
            labelDisplay0.Text += "7";
        }

        private void Button8_Clicked(object sender, EventArgs e)
        {
            labelDisplay0.Text += "8";
        }

        private void Button9_Clicked(object sender, EventArgs e)
        {
            labelDisplay0.Text += "9";
        }

        private void ButtonDot_Clicked(object sender, EventArgs e)
        {
            labelDisplay0.Text += ".";
        }

        private void ButtonAddition_Clicked(object sender, EventArgs e)
        {
            labelDisplay0.Text += "+";
        }

        private void ButtonSubtraction_Clicked(object sender, EventArgs e)
        {
            labelDisplay0.Text += "-";
        }

        private void ButtonMultiplication_Clicked(object sender, EventArgs e)
        {
            labelDisplay0.Text += "*";
        }

        private void ButtonDivide_Clicked(object sender, EventArgs e)
        {
            labelDisplay0.Text += "/";
        }

        private void ButtonCE_Clicked(object sender, EventArgs e)
        {
            labelDisplay0.Text = "";
           
        }

        private void ButtonDeleteSign_Clicked(object sender, EventArgs e)
        {
            if (labelDisplay0.Text.Length >0)
                labelDisplay0.Text = 
                    labelDisplay0.Text.Substring(0, labelDisplay0.Text.Length - 1);
        }

  


        private void ButtonEqual_Clicked(object sender, EventArgs e)
        {

            Calculations calculations = new Calculations();

            labelDisplay1.Text =
                calculations.CountSummationMultiplication(labelDisplay0.Text);



        }

        private void ButtonF_Clicked(object sender, EventArgs e)
        {

        }

        private void ButtonBracketLeft_Clicked(object sender, EventArgs e)
        {
           labelDisplay0.Text += "(";
        }

        private void ButtonBracketRight_Clicked(object sender, EventArgs e)
        {
           labelDisplay0.Text += ")";
        }


    }
}
