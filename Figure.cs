using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание2
{

    class Figure
    {
        private string Name;
        private double Per;
        public string GetName
        {
            get
            {
                return Name;
            }
        }
        public double GetPer
        {
            get
            {
                return Per;
            }
        }
        public Figure(Point a, Point b, Point c)
        {
            Name = "треугольник";
        }
        public Figure(Point a, Point b, Point c, Point d)
        {
            Name = "четырехугольник";
        }
        public Figure(Point a, Point b, Point c, Point d, Point e)
        {
            Name = "пятиугольник";
        }

        public double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(b.GetX - a.GetX, 2) + Math.Pow(b.GetY - a.GetY, 2));
        }
        public void PerimeterCalculator(Point a, Point b, Point c)
        {
            Per = LengthSide(a, b) + LengthSide(b, c) + LengthSide(c, a);
        }
        public void PerimeterCalculator(Point a, Point b, Point c, Point d)
        {
            Per = LengthSide(a, b) + LengthSide(b, c) + LengthSide(c, d) + LengthSide(d, a);
        }
        public void PerimeterCalculator(Point a, Point b, Point c, Point d, Point e)
        {
            Per = LengthSide(a, b) + LengthSide(b, c) + LengthSide(c, d) + LengthSide(d, e) + LengthSide(e, a);
        }
    }
}
