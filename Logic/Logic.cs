using System;

namespace Logic
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
            double delta = Math.Sqrt(Math.Pow(X - otherCircle.X, 2) + Math.Pow(Y - otherCircle.Y, 2));

            return Radius + otherCircle.Radius >= delta && delta >= Math.Abs(Radius - otherCircle.Radius);
        }

    }
}
