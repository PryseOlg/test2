using System;
using System.Drawing;

namespace Test.Logic {
    public class Triangle {
        public Point a { get; set; }
        public Point b { get; set; }
        public Point c { get; set; }

        public bool Exitst() {
            int count = 0;
            if (getLength(a, b) + getLength(b, c) > getLength(a, c))
                count++;
            if (getLength(a, b) + getLength(a, c) > getLength(b, c))
                count++;
            if (getLength(b, b) + getLength(a, c) > getLength(a, b))
                count++;
            return count == 3;
        }
        
        private int getLength(Point x, Point y) {
            return (int) Math.Sqrt(Math.Pow(x.X - y.X, 2) + Math.Pow(x.Y - y.Y, 2));
        }
    }
}