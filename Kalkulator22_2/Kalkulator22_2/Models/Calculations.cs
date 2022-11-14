using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Kalkulator22_2.Models
{
    public class Calculations
    {

    //podział stringa poprzez nawiasy
    public string StringSplitBracket(string s1)
        {
            List<int> listPositionLeftBracket = new List<int>();
            string errorSplit = "";
    
            for(int i=0; i<s1.Length; i++)
            {
                char c1 = s1[i];
                if ( c1 == '(')
                {
                    listPositionLeftBracket.Add(i);
                }
                if ( c1 == ')')
                {
                    if (listPositionLeftBracket.Count > 0)
                    {
                        string s2 = s1.Substring(listPositionLeftBracket.Last() + 1, i-listPositionLeftBracket.Last()-1 );

                        string s3 = CountSummationMultiplication(s2);


                        if (i + 1 < s1.Length)
                        {
                            s1 = s1.Substring(0, listPositionLeftBracket.Last()) + s3 + s1.Substring(i + 1);
                        }
                        else {
                            s1 = s1.Substring(0, listPositionLeftBracket.Last()) + s3;
                        }

                        listPositionLeftBracket.Remove(listPositionLeftBracket.Last());
                        i = i - 2 - s2.Length + s3.Length;

                    }
                    else
                    {
                        errorSplit = "brakuje nawiasu (";
                    }
                }
            }

            if (errorSplit == "") return CountSummationMultiplication(s1);             
            else return errorSplit;                   

        }




     //wyliczenie wyrazenia: dzielenie, mnozenie, odejmowanie, dodawanie --------------------------------
        public string CountSummationMultiplication(string mathExpression) {

            mathExpression = "+" + mathExpression;

            String[] separator1 = { "+", "-", "*", "/" };
            String[] number = mathExpression.Split(separator1, StringSplitOptions.RemoveEmptyEntries);

            String[] separator2 = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "." };
            String[] operation = mathExpression.Split(separator2, StringSplitOptions.RemoveEmptyEntries); ;

            string errorMathExpression = "";
            List<Element> elementList = new List<Element> { };

            for (int i = 0; i < number.Length; i++)
            {
                Element element = new Element();
                double d1 = 0;                              

                if (double.TryParse(number[i], NumberStyles.Any, CultureInfo.InvariantCulture, out d1))
                {
                    element.Number = d1;
                }
                else
                {
                    errorMathExpression = "bład zamiany liczby";
                    break;
                }

                //w zerowym elemencie operator może być tylko + lub ++ lub *-
                if (i == 0)
                {
                    if (!(operation[0] == "+" || operation[0] == "++" || operation[0] == "+-"))
                    {
                        errorMathExpression = "błędny operator pierwszej liczby";
                        break;
                    }
                        
                }

                if (operation[i].Length == 2)
                {
                    if (operation[i] == "+-")
                    {
                        element.Number = 0 - element.Number;
                        operation[i] = "+";
                    }
                    if (operation[i] == "--")
                    {
                        element.Number = 0 - element.Number;
                        operation[i] = "-";
                    }
                    if (operation[i] == "*-")
                    {
                        element.Number = 0 - element.Number;
                        operation[i] = "*";
                    }
                    if (operation[i] == "/-")
                    {
                        element.Number = 0 - element.Number;
                        operation[i] = "/";
                    }
                    if (operation[i].Length != 1)
                    {
                        errorMathExpression = "błędne połączenie operatorów";
                        break;
                    }
                }

                if (operation[i].Length == 1)
                {
                    element.Operation = operation[i];
                 }


                elementList.Add(element);
            }


            //za dużo operatorów, operator bez liczby
            if (errorMathExpression == "" && number.Length != operation.Length) 
                errorMathExpression = "operator bez liczby";


            if (errorMathExpression == "")
            {

                for (int i = 1; i < elementList.Count; i++)
                {
                    if (elementList[i].Operation == "/")
                    {
                        if (elementList[i].Number == 0)
                        {
                            errorMathExpression = "dzielenie przez zero";
                            break;
                        }
                        else
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
                    if (elementList[i].Operation == "*")
                    {
                        elementList[i - 1].Number = elementList[i - 1].Number * elementList[i].Number;
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

                for (int i = 1; i < elementList.Count; i++)
                {
                    if (elementList[i].Operation == "+")
                    {
                        elementList[i - 1].Number = elementList[i - 1].Number + elementList[i].Number;
                        elementList.RemoveAt(i);
                        i--;
                    }
                }

            }

            if (errorMathExpression != "")
            {
                return errorMathExpression;
            }
            else
            {                
                return elementList[0].Number.ToString().Replace(',','.');
            }
        }


    }
}
