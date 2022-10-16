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

  
       // public string countCummationMultiplication


        private void ButtonEqual_Clicked(object sender, EventArgs e)
        {
            string mathExpression = labelDisplay0.Text;
            if (mathExpression.Substring(0,1) !="+" || mathExpression.Substring(0, 1) != "-") 
                mathExpression = "+" + mathExpression;

            String[] separator1 = { "+", "-", "*", "/" };
            String[] number = mathExpression.Split(separator1, StringSplitOptions.RemoveEmptyEntries);

            String[] separator2 = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "."};
            String[] operation = mathExpression.Split(separator2, StringSplitOptions.RemoveEmptyEntries); ;


            string errorMathExpression = "";
            List<Element> elementList = new List<Element> { };

            for(int i = 0; i < number.Length; i++)
            {
                Element element = new Element();
                double d1 = 0;

                if (double.TryParse(number[i], out d1)) {
                    element.Number = d1;                  
                } else {
                    errorMathExpression = "bład zamiany liczby";
                    break;
                }         

                if (operation[i].Length == 1)
                {
                    //w pierwszym elemencie może być + lub -
                    if ( i==0 && !(operation[i] == "+" || operation[i] == "-" ) ) 
                    {
                        errorMathExpression = "błędny operator pierwszej liczby";
                        break;
                    }
                    element.Operation = operation[i];
                } else {
                    errorMathExpression = "błędny operator";
                    break;
                }

                elementList.Add(element);
            }

            if (errorMathExpression=="" && number.Length != operation.Length) errorMathExpression = "za dużo operatorów";

            if (errorMathExpression=="")
            {
                for (int i = 0; i < elementList.Count; i++)
                {
                    if (elementList[i].Operation == "*")
                    {
                        elementList[i - 1].Number = elementList[i - 1].Number * elementList[i].Number;
                        elementList.RemoveAt(i);
                        i--;
                    }
                }

                for (int i = 0; i < elementList.Count; i++)
                {
                    if (elementList[i].Operation == "/")
                    {
                        if (elementList[i].Number == 0)
                        {
                            errorMathExpression = "dzielenie przez zero";
                            break;
                        } else
                        {
                            elementList[i - 1].Number = elementList[i - 1].Number / elementList[i].Number;
                            elementList.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }

            if (errorMathExpression == "")
            {
                for (int i = 1; i < elementList.Count; i++)
                {
                    if (elementList[i].Operation == "+")
                    {
                        elementList[i - 1].Number = elementList[i - 1].Number + elementList[i].Number;
                        elementList.RemoveAt(i);
                        i--;
                    }
                }

                for (int i = 1; i < elementList.Count; i++)
                {
                    if (elementList[i].Operation == "-")
                    {
                        elementList[i - 1].Number = elementList[i - 1].Number - elementList[i].Number;
                        elementList.RemoveAt(i);
                        i--;
                    }
                }
            }

            if (errorMathExpression != "")
            {
                labelDisplay1.Text = errorMathExpression;
            } else
            {
                labelDisplay1.Text = elementList[0].Number.ToString();
            }

        }

        private void ButtonF_Clicked(object sender, EventArgs e)
        {

        }

        private void ButtonBracketLeft_Clicked(object sender, EventArgs e)
        {
           // labelDisplay0.Text += "(";
        }

        private void ButtonBracketRight_Clicked(object sender, EventArgs e)
        {
           // labelDisplay0.Text += ")";
        }


    }
}
