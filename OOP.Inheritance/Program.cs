using OOP.Inheritance;
using System.Drawing;
using Rectangle = OOP.Inheritance.Rectangle;

internal class Program
{
    private static void Main(string[] args)
    {

        //Çokbiçimlilik-Polymorphism örneği
        //CokBicimlilik_Polymorphism();


        //inheritance-virtual keyword'e kadar
        //VirtualMethod();


    }

    //Çokbiçimlilik-Polymorphism örneği
    private static void CokBicimlilik_Polymorphism()
    {
        var shapes = new List<Shape>()
        {
            new Rectangle(),
            new Circle(),
            new Triangle(),
            new Square()
        };

        foreach (var shape in shapes)
        {
            shape.Draw();
        }

        new Square().Calculate();
    }

    //inheritance-virtual keyword'e kadar
    private static void VirtualMethod()
    {
        var _s1 = new Rectangle();
        var _s2 = new Circle();

        _s1.X = 10;
        _s1.Y = 100;
        Console.WriteLine("{0},{1}", _s1.X, _s1.Y);
        _s1.Draw();

        _s2.X = 5;
        _s2.Y = 55;
        Console.WriteLine("{0},{1}", _s1.X, _s2.Y);
        _s2.Draw();


        new Triangle().Draw();
    }
}