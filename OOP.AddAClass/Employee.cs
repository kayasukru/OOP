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


        // Varsayılan constructor. Parametre almayan constructor Mutlaka olmalı.
        public Employee()
        {
            Console.WriteLine("Yapılandırıcı metod çalıştı.");
        }

        // overloading
        public Employee(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        // override 
        public override string? ToString()
        {
            return $"{FirstName} {LastName} {Age}";
        }

    }
}
