using System;
using System.Drawing;

namespace Test.Logic {
    public class Triangle {
        public Point a { get; set; }
        public Point b { get; set; }
        public Point c { get; set; }

        private int getLength(Point x, Point y) {
            return (int) Math.Sqrt(Math.Pow(x.X - y.X, 2) + Math.Pow(x.Y - y.Y, 2));
        }
    }
}