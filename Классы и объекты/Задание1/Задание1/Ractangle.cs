using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание1
{
    class Ractangle
    {
        double side1;
        double side2;

        public Ractangle(double sd1, double sd2)
        {
            side1 = sd1;
            side2 = sd2;
        }

        private double AreaCalculator(double sd1, double sd2)
        {
            return sd1 * sd2;
        }

        private double PerimeterCalculator(double sd1, double sd2)
        {
            return 2 * (sd1 + sd2);
        }

        public double Area
        {
            get
            {
                return AreaCalculator(side1, side2);
            }
        }

        public double Perimeter
        {
            get
            {
                return PerimeterCalculator(side1, side2);
            }
        }
    }
}
