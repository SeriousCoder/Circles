using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Circle
    {
        public double X;
        public double Y;
        public double Radius;

        public Circle(double x, double y, double r)
        {
            X = x;
            Y = y;
            Radius = r;
        }

        public bool Intersection(Circle otherCircle)
        {
            return Radius + otherCircle.Radius > Math.Sqrt(Math.Pow(X - otherCircle.X, 2) + Math.Pow(Y - otherCircle.Y, 2));
        }

    }
}
