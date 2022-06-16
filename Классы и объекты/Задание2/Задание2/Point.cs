using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание2
{
    class Point
    {
        private int X;
        private int Y;


        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int GetX
        {
            get
            {
                return X;
            }
        }
        public int GetY
        {
            get
            {
                return Y;
            }
        }
        
    }
}
