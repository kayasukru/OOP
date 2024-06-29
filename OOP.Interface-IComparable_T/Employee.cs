using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interface_IComparable_T
{
    public class Employee : IComparable<Employee>
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public decimal Salary { get; set; }

        public int CompareTo(Employee? other)
        {
            // Id'ye göre artan sıralar
            //return this.Id.CompareTo(other.Id);

            // FullName'e göre artan sıralar
            //return this.FullName.CompareTo(other.FullName);

            //Salary'ye göre azalan sıralar. Diğer property'ler de benzer şekilde azalan sırlanabilir.
            if (this.Salary < other.Salary) return 1;
            else if(this.Salary == other.Salary)return 0;
            else return -1;
        }
        
        //Çıktıyı biçimlendirir
        public override string ToString()
        {
            return $"{Id,-5} {FullName,-25} {Salary,-7}";
        }
    }
}
