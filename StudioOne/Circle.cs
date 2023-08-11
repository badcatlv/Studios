using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudioOne
{
    internal class Circle
    {
        public double area(double r)
        {
            double result = Math.Pow(r, 2.0) * Math.PI;
            return Math.Round(result, 3);
        }

        public double circum(double r)
        {
            double circumResult = 2 * Math.PI * r;
            return Math.Round(circumResult, 3);
        }

    }
}
