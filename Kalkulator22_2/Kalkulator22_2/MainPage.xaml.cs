﻿using Kalkulator22_2.Models;
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
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button0_Clicked(object sender, EventArgs e)
        {
            editor0.Text += "0";
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            editor0.Text += "1";
        }

        private void Button2_Clicked(object sender, EventArgs e)
        {
            editor0.Text += "2";
        }

        private void Button3_Clicked(object sender, EventArgs e)
        {
            editor0.Text += "3";
        }

        private void Button4_Clicked(object sender, EventArgs e)
        {
            editor0.Text += "4";
        }

        private void Button5_Clicked(object sender, EventArgs e)
        {
            editor0.Text += "5";
        }

        private void Button6_Clicked(object sender, EventArgs e)
        {
            editor0.Text += "6";
        }

        private void Button7_Clicked(object sender, EventArgs e)
        {
            editor0.Text += "7";
        }

        private void Button8_Clicked(object sender, EventArgs e)
        {
            editor0.Text += "8";
        }

        private void Button9_Clicked(object sender, EventArgs e)
        {
            editor0.Text += "9";
        }

        private void ButtonDot_Clicked(object sender, EventArgs e)
        {
            editor0.Text += ".";
        }

        private void ButtonAddition_Clicked(object sender, EventArgs e)
        {
            editor0.Text += "+";
        }

        private void ButtonSubtraction_Clicked(object sender, EventArgs e)
        {
            editor0.Text += "-";
        }

        private void ButtonMultiplication_Clicked(object sender, EventArgs e)
        {
            editor0.Text += "*";
        }

        private void ButtonDivide_Clicked(object sender, EventArgs e)
        {
            editor0.Text += "/";
        }

        private void ButtonBracketLeft_Clicked(object sender, EventArgs e)
        {
            editor0.Text += "(";
        }

        private void ButtonBracketRight_Clicked(object sender, EventArgs e)
        {
            editor0.Text += ")";
        }

        private void buttonAC_Clicked(object sender, EventArgs e)
        {
            editor0.Text = "";
        }        

        private void buttonDeleteSign_Clicked(object sender, EventArgs e)
        {
            if (editor0.Text.Length > 0)
                editor0.Text = editor0.Text.Substring(0, editor0.Text.Length - 1);
        }


        private void ButtonEqual_Clicked(object sender, EventArgs e)
        {
            //szerokość i wysokość ekranu
            var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;
            var realHeightInPx = mainDisplayInfo.Height;
            var realWidthInPx = mainDisplayInfo.Width;
            double hightCell = (double)realHeightInPx/10 ;
            double widthCell = (double)realWidthInPx/4 ;
                        

            //editor0.FontSize = 20;


            Calculations calculations = new Calculations();
            editor0.Text = calculations.StringSplitBracket(editor0.Text);
            

        }


    }
}
