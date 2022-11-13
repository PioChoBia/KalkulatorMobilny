using Kalkulator22_2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;


namespace Kalkulator22_2
{
    public partial class MainPage : ContentPage
    {
        public string stringEdytorAll = "";
        public string stringEdytorNewExpression = "";

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button0_Clicked(object sender, EventArgs e)
        {
            stringEdytorNewExpression += "0";
            editor0.Text = stringEdytorAll + stringEdytorNewExpression;
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            stringEdytorNewExpression += "1";
            editor0.Text = stringEdytorAll + stringEdytorNewExpression;
        }

        private void Button2_Clicked(object sender, EventArgs e)
        {
            stringEdytorNewExpression += "2";
            editor0.Text = stringEdytorAll + stringEdytorNewExpression;
        }

        private void Button3_Clicked(object sender, EventArgs e)
        {
            stringEdytorNewExpression += "3";
            editor0.Text = stringEdytorAll + stringEdytorNewExpression;
        }

        private void Button4_Clicked(object sender, EventArgs e)
        {
            stringEdytorNewExpression += "4";
            editor0.Text = stringEdytorAll + stringEdytorNewExpression;
        }

        private void Button5_Clicked(object sender, EventArgs e)
        {
            stringEdytorNewExpression += "5";
            editor0.Text = stringEdytorAll + stringEdytorNewExpression;
        }

        private void Button6_Clicked(object sender, EventArgs e)
        {
            stringEdytorNewExpression += "6";
            editor0.Text = stringEdytorAll + stringEdytorNewExpression;
        }

        private void Button7_Clicked(object sender, EventArgs e)
        {
            stringEdytorNewExpression += "7";
            editor0.Text = stringEdytorAll + stringEdytorNewExpression;
        }

        private void Button8_Clicked(object sender, EventArgs e)
        {
            stringEdytorNewExpression += "8";
            editor0.Text = stringEdytorAll + stringEdytorNewExpression;
        }

        private void Button9_Clicked(object sender, EventArgs e)
        {
            stringEdytorNewExpression += "9";
            editor0.Text = stringEdytorAll + stringEdytorNewExpression;
        }

        private void ButtonDot_Clicked(object sender, EventArgs e)
        {
            stringEdytorNewExpression += ".";
            editor0.Text = stringEdytorAll + stringEdytorNewExpression;
        }

        private void ButtonAddition_Clicked(object sender, EventArgs e)
        {
            stringEdytorNewExpression += "+";
            editor0.Text = stringEdytorAll + stringEdytorNewExpression;
        }

        private void ButtonSubtraction_Clicked(object sender, EventArgs e)
        {
            stringEdytorNewExpression += "-";
            editor0.Text = stringEdytorAll + stringEdytorNewExpression;
        }

        private void ButtonMultiplication_Clicked(object sender, EventArgs e)
        {
            stringEdytorNewExpression += "*";
            editor0.Text = stringEdytorAll + stringEdytorNewExpression;
        }

        private void ButtonDivide_Clicked(object sender, EventArgs e)
        {
            stringEdytorNewExpression += "/";
            editor0.Text = stringEdytorAll + stringEdytorNewExpression;
        }

        private void ButtonBracketLeft_Clicked(object sender, EventArgs e)
        {
            stringEdytorNewExpression += "(";
            editor0.Text = stringEdytorAll + stringEdytorNewExpression;
        }

        private void ButtonBracketRight_Clicked(object sender, EventArgs e)
        {
            stringEdytorNewExpression += ")";
            editor0.Text = stringEdytorAll + stringEdytorNewExpression;
        }

        private void buttonAC_Clicked(object sender, EventArgs e)
        {
            stringEdytorNewExpression = "";
            editor0.Text = stringEdytorAll;
        }        

        private void buttonDeleteSign_Clicked(object sender, EventArgs e)
        {
            if (stringEdytorNewExpression.Length > 0)
            {
                stringEdytorNewExpression =
                    stringEdytorNewExpression.Substring(0, stringEdytorNewExpression.Length - 1);
            }
            editor0.Text = stringEdytorAll + stringEdytorNewExpression;
        }


        private void ButtonEqual_Clicked(object sender, EventArgs e)
        {
            if ( stringEdytorNewExpression.Length>0)
            {
                Calculations calculations = new Calculations();

                stringEdytorAll +=
                    stringEdytorNewExpression + System.Environment.NewLine + System.Environment.NewLine;

                stringEdytorNewExpression = calculations.StringSplitBracket(stringEdytorNewExpression);
                editor0.Text = stringEdytorAll + stringEdytorNewExpression;
            }

        }


    }
}
