using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenClosed
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Developer> developers = new List<Developer>
            {
                new Junior(0, "Filankes", 500),
                new Senior(1, "Senior", 1500)
            };

            foreach (var developer in developers)
            {
                Console.WriteLine(developer.GetBonus());
            }
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
    /* // Good Example
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
        }*/



    public abstract class Developer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public abstract double GetBonus();

        public Developer(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

    }

    public class Junior : Developer
    {
        public override double GetBonus() => Salary * 0.1;

        public Junior(int id, string name, double salary) : base(id, name, salary) { }
    }

    public class Senior : Developer
    {
        public override double GetBonus() => Salary * 0.25;

        public Senior(int id, string name, double salary) : base(id, name, salary) { }
    }

    public class Calculate
    {
        public double TotalBonus(Developer[] developers)
        {
            double totalBonus = 0;
            foreach (var developer in developers)
            {
                Console.WriteLine(developer.GetBonus());
                totalBonus = developer.GetBonus();
            }

            return totalBonus;
        }
    }
}
