using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    public class Square : Rectangle
    {

        public Square()
        {
            
        }

        public Square(int x, int y) : base(x, y)
        {
            
        }
        new public void Calculate()
        {
            System.Console.WriteLine("Calculated by Square... ");
        }

    }
}
