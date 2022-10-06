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
            string mathExpression = labelDisplay0.Text;
            if (mathExpression.Substring(0,1) !="+" || mathExpression.Substring(0, 1) != "-") 
                mathExpression = "+" + mathExpression;

            String[] separatorOperation1 = { "+", "-", "*", "/", "(", ")" };
            String[] number = mathExpression.Split(separatorOperation1, StringSplitOptions.RemoveEmptyEntries);

            String[] separatorOperation2 = { "0", "1", "2", "3", "4", "5",
                "6", "7", "8", "9", "."};
            String[] operation = mathExpression.Split(separatorOperation2, StringSplitOptions.RemoveEmptyEntries); ;


            bool isErrorMathExpression = false;
            List<Element> elementList = new List<Element> { };
            double d1 = 0;

            

            for(int i = 0; i < number.Length; i++)
            {
                Element element = new Element();

                if (double.TryParse(number[i], out d1)) {
                    element.Number = d1;                  
                } else {
                    isErrorMathExpression = true;
                    break;
                }         

                if (operation[i].Length == 1)
                {
                    element.Operation = operation[i];
                } else {
                    isErrorMathExpression = true;
                    break;
                }

                elementList.Add(element);
            }

            string s1 = "";
            if (isErrorMathExpression)
            {
                s1 = "błąd";
            } else
            {
                foreach( Element e1 in elementList)
                {
                    s1+=e1.Operation + " " + e1.Number.ToString()+"  ";
                }
            }
                

            labelDisplay1.Text = s1;

        }

        private void buttonF_Clicked(object sender, EventArgs e)
        {

        }

        private void buttonBracketLeft_Clicked(object sender, EventArgs e)
        {
           // labelDisplay0.Text += "(";
        }

        private void buttonBracketRight_Clicked(object sender, EventArgs e)
        {
           // labelDisplay0.Text += ")";
        }


    }
}
