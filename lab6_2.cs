using System;
using System.Collections;





namespace Lab6_2
{
    public class Program
    {
        public void Main(string[] args)
        {
            FiguresContainer fc = new FiguresContainer(new Circle(2, "Red"), new Circle(3.6, "Green"), new Square(10), new Square(12));
            foreach (IGeometry i in fc) {
                Console.WriteLine(i);
            }
        }
    }
    interface IGeometry {
        double AreaOf{get;}
        void Info();
    }
 
    class FiguresContainer: IEnumerable {
        IGeometry[] figure;
 
        public FiguresContainer(params IGeometry[] figure) {
            this.figure = figure;
        }
        
        IEnumerator IEnumerable.GetEnumerator() {
            return figure.GetEnumerator();
        }      
    }
 
    class Circle:IGeometry {
        double radius;
        string color;
 
        public Circle(double r, string c) {
            this.radius = r;
            this.color = c;
        }
 
        public double AreaOf {
            get { return radius*radius*Math.PI; }
        }
 
        public override string ToString() {
            return "Circle info!\nRadius: " + radius + "\nColor: " + color + "\nArea: " + AreaOf + "\n- - - - - - - - -";
        }
 
        public void Info() {
            Console.WriteLine(ToString());
        }
    }
 
    class Square:IGeometry {
        double side; 
        public Square(double side) {
            this.side = side;
        }
 
        public double Perimeter() {
            return 4 * side;
        }
 
        public double AreaOf {
            get { return side * side; }
        }
 
        public override string ToString() {
            return "Square info!\nSide: " + side + "\nPerimeter: " + Perimeter() + "\nArea: " + AreaOf + "\n- - - - - - - - -";
        }
 
        public void Info() {
            Console.WriteLine(ToString());
        }       
    }
}