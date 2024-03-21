/*Develop a C# program to create a class named shape. Create three subclasses namely: circle,triangle 
and square, each class has two member functions named draw() and erase(). Demonstrate 
polymorphism concepts by developing suitable methods, defining member data and main program*/
using System;
class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("drawing shape");
    }
    public virtual void Erase()
    {
        Console.WriteLine("erasing shape");
    }
}
class Circle:Shape
{
    public override void Draw()
    {
        Console.WriteLine("drawing circle");
    }
    public override void Erase()
    {
        Console.WriteLine("erasing circle");
    }
}
class Triangle:Shape
{
    public override void Draw()
    {
        Console.WriteLine("drawing triangle");
    }
    public override void Erase()
    {
        Console.WriteLine("erasing triangle");
    }
}

class Square:Shape
{
    public override void Draw()
    {
        Console.WriteLine("drawing square");
    }
    public override void Erase()
    {
        Console.WriteLine("erasing square");
    }
}
class Polymorphism
{
    static void Main()
    {
        Shape s;
        s=new Circle();
        s.Draw();
        s.Erase();
        s=new Triangle();
        s.Draw();
        s.Erase();
        s=new Square();
        s.Draw();
        s.Erase();
    }
}
