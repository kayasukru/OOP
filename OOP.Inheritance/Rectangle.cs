using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    //sealed kavramı sınıfı mühürler.
    //mühürlenen sınıftan sınıf türetilemez.
    // Non Inheritance
    // Derleme hatası verir
    
    //public sealed class Rectangle : Shape
    public class Rectangle : Shape
    {
        public Rectangle()
        {

        }

        public Rectangle(int x, int y) : base(x, y)
        {
        }
        //sealed kavramı metodu mühürler
        //mühürlenen metoddan metod türetilemez
        //Non Inheritance
        //Derleme hatası verir

        //public sealed override void Draw()
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
