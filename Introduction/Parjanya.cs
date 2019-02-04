using System;
using System.Collections.Generic;
using System.Text;

namespace Introduction
{
    public class Parjanya
    {
        public static void Start()
        {
            var s = new Square(10);
            s.Print();
            Console.WriteLine(s.GetArea());

            var r = new Rectangle(10, 5);
            r.Print();
            Console.WriteLine(r.GetArea());

            var c = new Circle(10);
            c.Print();
            Console.WriteLine(c.GetArea());

            Console.ReadKey();
        }
    }

    public abstract class Shape
    {
        public Shape()
        {
        }

        public abstract void Print();

        public abstract double GetArea();
    }

    public class Rectangle : Shape
    {
        protected int width;
        protected int height;

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public override void Print()
        {
            //Console.WriteLine("Width: " + this.width +", Height: " + this.height + "");
            //Console.WriteLine(string.Format("Width: {0}, Height: {1}", this.width, this.height));
            Console.WriteLine($"Width: {this.width}, Height: { this.height }");
        }

        public override double GetArea()
        {
            return width * height;
        }
    }

    public class Square : Rectangle
    {
        public Square(int edgeLength): base(edgeLength, edgeLength)
        {

        }
    }
    
    public class Circle: Shape
    {
        private int radiaus;

        public Circle(int radiaus)
        {
            this.radiaus = radiaus;
        }

        public override void Print()
        {
            Console.WriteLine("Radiaus is: " + this.radiaus);
        }

        public override double GetArea()
        {
            return Math.PI * radiaus * radiaus;
        }
    }
}

