using System;

namespace Lab_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(5, 5);
            Point point2 = new Point(3, 4);
            Point point3 = new Point(2, 2);
            Point point4 = new Point(1, 1);

            Figure figure = new Figure(point1, point2, point3, point4);
            figure.PerimeterCalculator();
        }
    }
    public class Point
    {

        public Point(int integer1, int integer2, string string1 = "")
        {
            I1 = integer1;
            I2 = integer2;
            S1 = string1;
        }

        public int I1 { get; }
        public int I2 { get; }
        public string S1 { get; }
    }
    public class Figure
    {
        private double s1, s2, s3, s4, s5;
        public Figure(Point a, Point b, Point c)
        {
            s1 = LengthSide(a, b);
            s2 = LengthSide(b, c);
            s3 = LengthSide(c, a);
        }
        public Figure(Point a, Point b, Point c, Point d)
        {
            s1 = LengthSide(a, b);
            s2 = LengthSide(b, c);
            s3 = LengthSide(c, d);
            s4 = LengthSide(d, a);
        }
        public Figure(Point a, Point b, Point c, Point d, Point e)
        {
            s1 = LengthSide(a, b);
            s2 = LengthSide(b, c);
            s3 = LengthSide(c, d);
            s4 = LengthSide(d, e);
            s5 = LengthSide(e, a);
        }

        public static double LengthSide(Point a, Point b)
        {
            return Math.Abs(Math.Sqrt(Math.Pow(a.I1 - b.I1, 2) + Math.Pow(a.I2 - b.I2, 2)));
        }

        public void PerimeterCalculator()
        {
            if (s5 != 0)
            {
                double perimeter = s1 + s2 + s3 + s4 + s5;
                Console.WriteLine(perimeter);
            }
            else if (s5 == 0 & s4 != 0)
            {
                double perimeter = s1 + s2 + s3 + s4;
                Console.WriteLine(perimeter);
            }
            else
            {
                double perimeter = s1 + s2 + s3;
                Console.WriteLine(perimeter);
            }
        }
    }

}
