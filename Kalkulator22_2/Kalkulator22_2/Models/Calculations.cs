using System;
using System.Collections.Generic;
using System.Text;

namespace Kalkulator22_2.Models
{
    public class Calculations
    {





     //liczenie prostego wyrazenia z mnozeniem i dodawaniem-----------------------------------------------------------------------------
        public string CountSummationMultiplication(string mathExpression) {

            if (mathExpression.Substring(0, 1) != "+" || mathExpression.Substring(0, 1) != "-")
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

                if (double.TryParse(number[i], out d1))
                {
                    element.Number = d1;
                }
                else
                {
                    errorMathExpression = "bład zamiany liczby";
                    break;
                }

                if (operation[i].Length == 1)
                {
                    //w pierwszym elemencie może być + lub -
                    if (i == 0 && !(operation[i] == "+" || operation[i] == "-"))
                    {
                        errorMathExpression = "błędny operator pierwszej liczby";
                        break;
                    }
                    element.Operation = operation[i];
                }
                else
                {
                    errorMathExpression = "błędny operator";
                    break;
                }

                elementList.Add(element);
            }

            if (errorMathExpression == "" && number.Length != operation.Length) errorMathExpression = "za dużo operatorów";

            if (errorMathExpression == "")
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
                return errorMathExpression;
            }
            else
            {
                return elementList[0].Number.ToString();
            }
        }












    }
}
