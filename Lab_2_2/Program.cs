using System;

namespace Lab_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double s1, s2;
            Console.WriteLine("Введите значение первой стороны: ");
            s1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение второй стороны: ");
            s2 = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle(s1, s2);
            Console.WriteLine($"Площадь: {rectangle.Area}, периметр: {rectangle.Perimeter} ");
        }
    }

    public class Rectangle
    {
        private double side1, side2;

        public Rectangle(double Side1, double Side2)
        {
            side1 = Side1;
            side2 = Side2;
        }

        public double Area { get { return AreaCalculator(); } }
        public double Perimeter { get { return PerimeterCalculator(); } }

        public double AreaCalculator()
        {
            return side1 * side2;
        }

        public double PerimeterCalculator()
        {
            return 2 * (side1 + side2);
        }
    }
}