using System;
namespace pma2025
{
    class Shape {
        public virtual void Display() {
            Console.WriteLine("I am a Shape!");
        }
    }    

    class Circle : Shape {
        public override void Display() {
            Console.WriteLine("I am a Circle!");
        }
    }
    
    class Triangle : Shape {
        public override void Display()  {
            Console.WriteLine("I am a Triangle!");
        }
    }
    class Square : Shape {
        public override void Display() {
            Console.WriteLine("I am a Square!");
        }
    }

    class Substituability {
        public static void Main(string[] args) {
            //Create an ArrayList to hold Shape objects
            List<Shape> shapeList = new List<Shape>();
            //Create a Shape object
            Shape shape = new Shape();
            //Create a Triangle object
            Triangle triangle = new Triangle();
            //Create a Circle object
            Circle circle = new Circle();
            //Create a Square object
            Square square = new Square();
            //Add all the Shape objects to shapeList
            shapeList.Add(shape);
            shapeList.Add(triangle);
            shapeList.Add(circle);
            shapeList.Add(square);
            //Print out the objects in shapeList
            foreach (Shape s in shapeList)
                s.Display();
        }
    }
}