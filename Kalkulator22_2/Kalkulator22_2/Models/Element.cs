using System;
using System.Collections.Generic;
using System.Text;

namespace Kalkulator22_2
{
    public class Element
    {
        public string Operation { get; set; }
        public double Number { get; set; }

        public Element()
        {
            Operation = "";
            Number = 0;
        }

        public Element(string s1, double d1)
        {
            Operation = s1;
            Number = d1;
        }
    }
}
