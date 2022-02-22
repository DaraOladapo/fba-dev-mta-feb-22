using System;

namespace ShapesConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle niceRectangle = new Rectangle(12.5, 52);
            var rectangleArea = niceRectangle.GetArea();
            Console.WriteLine(rectangleArea);
            var rectanglePerimeter = niceRectangle.GetPerimeter();
            Console.WriteLine(rectanglePerimeter);
        }
    }
    class Rectangle
    {
        private double length;
        private double width;
        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }
        public double GetArea()
        {
            return length * width;
        }
        public double GetPerimeter()
        {
            return 2 * (length + width);
        }
    }
}
