using System;

namespace ShapesConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rectangle niceRectangle = new Rectangle(12.5, 52);
            // Rectangle niceRectangle = new Rectangle();
            // var rectangleArea = niceRectangle.GetArea(12.5,52);
            // Console.WriteLine(rectangleArea);

            // Rectangle anotherRectange = new Rectangle();
            // var anotherRectangleArea = anotherRectange.GetArea(18.5, 5);
            // var rectanglePerimeter = niceRectangle.GetPerimeter();
            // Console.WriteLine(rectanglePerimeter);
            // niceRectangle.Speak();
            // PropertiesInCSharp propInCS = new PropertiesInCSharp();
            // propInCS.Greetings();
            // Console.WriteLine(propInCS.FirstName);
            // Console.ReadKey();
        }
    }
    class Rectangle
    {
        private double length;
        private double width;
        public Rectangle()
        {
        }
        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }
        public double GetArea(double length, double width)
        {
            //this is a commment
            var area = length * width;
            return area;
        }
        public double GetArea(){
            return length * width;
        }
        public double GetPerimeter()
        {
            return 2 * (length + width);
        }
  
        public void Speak(){
            Console.WriteLine("I am a rectangle");
        }
    }
}
