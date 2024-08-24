using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.AddAClass
{
    internal class Employee
    {
        private string _firstName;
        private string _lastName;

        private List<Employee> _list;

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }

        public int Age { get; set; }

        // _list değişkenine değer atama
        // Tek satırda
        //public List<Employee> Employees => _list;
        //veya constructorda tanımlama yapılır

        // Varsayılan constructor. Parametre almayan constructor Mutlaka olmalı.
        public Employee()
        {
            Console.WriteLine("Yapılandırıcı metod çalıştı.");

            // _list değişkenine değer atama
            _list = new List<Employee>();
        }

        // overloading
        public Employee(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;

            // _list değişkenine değer atama
            _list = new List<Employee>();
        }

        // override 
        public override string? ToString()
        {
            // -20, 20 karakterlik alan ayırır sola hizalar
            // -15, 15 karakterlik alan ayırı sola hizalar
            // 5, 5 karakterlik alan ayırır sağa hizalar
            return $"{FirstName,-20} {LastName,-15} ({Age,5})";
        }

        //Add() metodu eklendi
        public void Add(Employee employee)
        {
            _list.Add(employee);
        }

        //AddRange() metodu eklendi
        public void AddRange(params Employee[] employees)
        {
            _list.AddRange(employees);
        }

        //GetEmployee() metodu eklendi
        //Tek satırda lambda yöntemi ile 
        //public List<Employee> GetEmployees() => _list;

        //veya klasik yöntem ile
        public List<Employee> GetEmployees()
        {
            return _list;
        }

    }
}
