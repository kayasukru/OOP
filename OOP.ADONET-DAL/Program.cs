using System.Data;
using System.Data.SqlClient;
using OOP.ADONET_DAL.DAL.Concrete;
using OOP.ADONET_DAL.Entities;

namespace OOP.ADONET_DAL;

internal class Program
{
    private static void Main(string[] args)
    {
        //Product Add
        var _productDal = new ProductDal();
        var product = new Product
        {
            ProductName = "Domates",
            UnitPrice = 30,
            UnitsInStock = 100
        };
        //_productDal.Add(product);
        //Product List (After Add)
        Console.WriteLine();
        Console.WriteLine("Product List (After Add)");
        _productDal.GetAll().ForEach(p => Console.WriteLine(p.ProductId + " " + p.ProductName + " " + p.UnitPrice));

        // Product Delete
        //_productDal.Delete(new Product { ProductId = 89 });
        //Product List (After Delete)
        Console.WriteLine();
        Console.WriteLine("Product List (After Delete)");
        _productDal.GetAll().ForEach(p => Console.WriteLine(p.ProductId + " " + p.ProductName + " " + p.UnitPrice));

        // Product Update
        _productDal.Update(new Product
        {
            ProductId = 88,
            ProductName = "Patlıcan",
            UnitPrice = 10,
            UnitsInStock = 100
        });
        //Product List (After Update)
        Console.WriteLine();
        Console.WriteLine("Product List (After Update)");
        _productDal.GetAll().ForEach(p => Console.WriteLine(p.ProductId + " " + p.ProductName + " " + p.UnitPrice));


        // Employee List
        Console.WriteLine();
        Console.WriteLine("Employee List");
        var _employeeDal = new EmployeeDal();   

        var _list = _employeeDal.GetAll();

        foreach (var employee in _list)
        {
            Console.WriteLine(employee);
        }
    }

    // Delete Method
    private static void Delete()
    {
        var employee = new Employee()
        {
            EmployeeID = 15,
        };
        new EmployeeDal().Delete(employee);
    }

    // Update Method
    private static void Update()
    {
        var employee = new Employee()
        {
            EmployeeID = 11,
            FirstName = "Nurcan",
            LastName = "Boz",
        };

        new EmployeeDal().Update(employee);
    }

    // Read Method
    private static void Read()
    {
        new EmployeeDal().GetAll().ForEach(e => Console.WriteLine(e));
    }

    // Create Method
    private static void Create()
    {
        var employee = new Employee()
        {
            FirstName = "Hatice",
            LastName = "Yalçın",
        };

        new EmployeeDal().Add(employee);

    }
}
