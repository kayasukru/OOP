using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    public class Rectangle : Shape
    {
        public Rectangle()
        {

        }

        public Rectangle(int x, int y) : base(x, y)
        {
        }
        public override void Draw()
        {
            Console.WriteLine("Rectangle drawing task...");
            //base.Draw();
        }

        public void Calculate()
        {
            System.Console.WriteLine("Calculated by Rectangular...");
        }

    }
}
