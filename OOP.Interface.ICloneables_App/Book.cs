using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interface.ICloneables_App
{
    public class Book : ICloneable
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }


        // a deep copy
        // shallow copy
        public object Clone()
        {
            ////deep copy
            //return new Book()
            //{
            //    Id = this.Id,
            //    Title = this.Title,
            //    Price = this.Price
            //};

            //shallow copy -> yukarıdaki kopyalama işlemi ile aynı işlemi yapar
            return this.MemberwiseClone();
        }
    }
}
