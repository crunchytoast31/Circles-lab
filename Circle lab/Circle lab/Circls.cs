using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_lab
{
    internal class Circles
    {
        public Circles(double radius)
        {




        }

        public string CalculateCircumference(double radius)
        {
            double calcualted = 2 * Math.PI * radius;
            string formattedCircumference = "The calculated circumfrence is :" + Math.Round(calcualted, 2);

            return formattedCircumference;

        }

        public string CalculateArea(double radius)
        {
            double calcualted = Math.PI * radius * radius;
            string formattedArea = "The calcualted area of your circle is: " + Math.Round(calcualted, 2);


            return formattedArea;
        }
    }
}
