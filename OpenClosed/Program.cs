using System;
using System.Linq;

namespace OpenClosed
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }




    /* //Bad Example
    public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }

    public class Circle
    {
        public double Radius { get; set; }
    }

    public class Calculate
    {
        public double Area(object[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                if (shape is Rectangle r)
                {
                    area += r.Height * r.Width;
                }
                else if (shape is Circle c)
                {
                    area += c.Radius * c.Radius * Math.PI;
                }
            }

            return area;
        }
    }*/



    // Good Example
    public abstract class Shape
    {
        public abstract double Area();
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double Area() => Width * Height;
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double Area() => Radius * Radius * Math.PI;
    }

    public class Calculate
    {
        public double Area(Shape[] shapes)
        {
            return shapes.Sum(shape => shape.Area());
        }
    }
}
