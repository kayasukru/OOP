using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    public class Rectangle : Shape
    {
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
