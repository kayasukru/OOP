using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces.IFormattables
{
    public class Employee : IFormattable
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{Title} {FirstName} {LastName}";

        // object genel nesnesinin ToString() metodu baskıladık,
        // yerine kendi ToString() metodumuzu yazdık.
        //public override string ToString()
        //{
        //    return $"{FullName}";
        //}

        // System.IFormattable interface'inden gelen ToString() metodları

        //parametresiz
        public override string ToString()
        {
            return this.ToString("F", CultureInfo.CurrentCulture);
        }

        // tek parametreli
        public string ToString(string format)
        {
            return this.ToString(format, CultureInfo.CurrentCulture);
        }

        // iki parametreli
        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            if(String.IsNullOrEmpty(format))
                format = "F";
            
            if(formatProvider == null)
                formatProvider = CultureInfo.CurrentCulture;

            switch (format.ToUpper())
            {
                case "F":
                    return $"{Id, -5} {Title, -20} {FirstName, -15} {LastName, -15}";
                case "FL":
                    return $"{FirstName} {LastName}";
                case "LF":
                    return $"{LastName} {FirstName}";
                case "S":
                    return $"{LastName} {FirstName[0]}";
                default:
                    return $"{format} formatı desteklenmiyor";
            }
        }
    }
}
