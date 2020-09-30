using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter2Studio
{
    class Circle
    {
        public static double areaOfCircle(double radius)
        {
             return (Math.PI * radius * radius);
        }

        public static double getDiameter(double radius)
        {
            return 2 * radius;
        }

        public static double getCircumference(double radius)
        {
            return 2 * Math.PI * radius;
        }
    }
}
