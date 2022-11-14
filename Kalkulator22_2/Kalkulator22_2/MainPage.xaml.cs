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
        public string stringEditorAll = "";
        public string stringEditorNewExpression = "";

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button0_Clicked(object sender, EventArgs e)
        {
            stringEditorNewExpression += "0";
            editor0.Text = stringEditorAll + stringEditorNewExpression;
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            stringEditorNewExpression += "1";
            editor0.Text = stringEditorAll + stringEditorNewExpression;
        }

        private void Button2_Clicked(object sender, EventArgs e)
        {
            stringEditorNewExpression += "2";
            editor0.Text = stringEditorAll + stringEditorNewExpression;
        }

        private void Button3_Clicked(object sender, EventArgs e)
        {
            stringEditorNewExpression += "3";
            editor0.Text = stringEditorAll + stringEditorNewExpression;
        }

        private void Button4_Clicked(object sender, EventArgs e)
        {
            stringEditorNewExpression += "4";
            editor0.Text = stringEditorAll + stringEditorNewExpression;
        }

        private void Button5_Clicked(object sender, EventArgs e)
        {
            stringEditorNewExpression += "5";
            editor0.Text = stringEditorAll + stringEditorNewExpression;
        }

        private void Button6_Clicked(object sender, EventArgs e)
        {
            stringEditorNewExpression += "6";
            editor0.Text = stringEditorAll + stringEditorNewExpression;
        }

        private void Button7_Clicked(object sender, EventArgs e)
        {
            stringEditorNewExpression += "7";
            editor0.Text = stringEditorAll + stringEditorNewExpression;
        }

        private void Button8_Clicked(object sender, EventArgs e)
        {
            stringEditorNewExpression += "8";
            editor0.Text = stringEditorAll + stringEditorNewExpression;
        }

        private void Button9_Clicked(object sender, EventArgs e)
        {
            stringEditorNewExpression += "9";
            editor0.Text = stringEditorAll + stringEditorNewExpression;
        }

        private void ButtonDot_Clicked(object sender, EventArgs e)
        {
            stringEditorNewExpression += ".";
            editor0.Text = stringEditorAll + stringEditorNewExpression;
        }

        private void ButtonAddition_Clicked(object sender, EventArgs e)
        {
            stringEditorNewExpression += "+";
            editor0.Text = stringEditorAll + stringEditorNewExpression;
        }

        private void ButtonSubtraction_Clicked(object sender, EventArgs e)
        {
            stringEditorNewExpression += "-";
            editor0.Text = stringEditorAll + stringEditorNewExpression;
        }

        private void ButtonMultiplication_Clicked(object sender, EventArgs e)
        {
            stringEditorNewExpression += "*";
            editor0.Text = stringEditorAll + stringEditorNewExpression;
        }

        private void ButtonDivide_Clicked(object sender, EventArgs e)
        {
            stringEditorNewExpression += "/";
            editor0.Text = stringEditorAll + stringEditorNewExpression;
        }

        private void ButtonBracketLeft_Clicked(object sender, EventArgs e)
        {
            stringEditorNewExpression += "(";
            editor0.Text = stringEditorAll + stringEditorNewExpression;
        }

        private void ButtonBracketRight_Clicked(object sender, EventArgs e)
        {
            stringEditorNewExpression += ")";
            editor0.Text = stringEditorAll + stringEditorNewExpression;
        }

        private void buttonAC_Clicked(object sender, EventArgs e)
        {
            stringEditorNewExpression = "";
            editor0.Text = stringEditorAll;
        }        

        private void buttonDeleteSign_Clicked(object sender, EventArgs e)
        {
            if (stringEditorNewExpression.Length > 0)
            {
                stringEditorNewExpression =
                    stringEditorNewExpression.Substring(0, stringEditorNewExpression.Length - 1);
            }
            editor0.Text = stringEditorAll + stringEditorNewExpression;
        }


        private void ButtonEqual_Clicked(object sender, EventArgs e)
        {
            if ( stringEditorNewExpression.Length>0)
            {
                Calculations calculations = new Calculations();

                stringEditorAll +=
                    stringEditorNewExpression + System.Environment.NewLine + System.Environment.NewLine;

                stringEditorNewExpression = calculations.StringSplitBracket(stringEditorNewExpression);
                editor0.Text = stringEditorAll + stringEditorNewExpression;
            }

        }


    }
}
