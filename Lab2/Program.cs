using System;

namespace Lab2
{
    interface IPrint
    {
        void Print();
    }
    abstract class Figure
    {
        public string Type { get; set; }
        public abstract float Area();
        public override string ToString()
        {
            return this.Type + " площадью " + Area().ToString();
        }
    }
    class Rectangle : Figure, IPrint
    {
        //private string Type = "прямоугольник";
        public float height { get; set; }
        
        public float width { get; set; }
        public Rectangle(float a, float b) { height = a;  width = b; Type = "прямоугольник"; }
        public override float Area()
        {
            return height * width;
        }
        public void Print()
        {
            Console.WriteLine(ToString());
        }
    }
    class Square: Rectangle, IPrint
    {

     public float side { get; set; }
        public Square(float a) : base(a, a)
        {
            Type = "квадрат";
            side = a;
        }
       
    }
   
    class Circle: Figure, IPrint
    {
        //private string Type=
        public float Rad { get; set; }
        public Circle(float a) 
        {
            Rad = a;
            Type = "круг";
        }

        public override float Area()
        {
            return (float)Math.PI * Rad *Rad;
        }

        public void Print()
        {
            Console.WriteLine(ToString());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle pug = new Rectangle(4,5);
            pug.Print();

            Circle cir = new Circle(3);
            cir.Print();

            Square sq = new Square(3);
            sq.Print();
         }
    }
}
