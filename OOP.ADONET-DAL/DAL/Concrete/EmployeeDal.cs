using OOP.ADONET_DAL.DAL.Abstract;
using OOP.ADONET_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.ADONET_DAL.DAL.Concrete
{
    public class EmployeeDal : IEmployeeDal
    {
        public void Add(Employee entity)
        {
            var cmd = new SqlCommand("INSERT INTO Employees(FirstName, LastName) VALUES(@firstName, @lastName)");
            cmd.Parameters.AddWithValue("firstName", entity.FirstName);
            cmd.Parameters.AddWithValue("lastName", entity.LastName);

            RDMS.SqlNonQuery(cmd); // sql komutu çalıştırılır. etkilenen kayıt sayısı s değişkenine depolanır

        }

        public void Delete(Employee entity)
        {
            var cmd = new SqlCommand("DELETE FROM Employees WHERE EmployeeID = @employeeId");
            cmd.Parameters.AddWithValue("employeeId", entity.EmployeeID);

            RDMS.SqlNonQuery(cmd); // sql komutu çalıştırılır. etkilenen kayıt sayısı s değişkenine depolanır
        }

        public List<Employee> GetAll()
        {
            var _list = new List<Employee>();

            var cmd = new SqlCommand("SELECT EmployeeID, FirstName, LastName FROM Employees");

            var ds = RDMS.SqlReader(cmd);

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                _list.Add(new Employee()
                {
                    EmployeeID = int.Parse(item[0].ToString()), // [0] ifadesi sorgudaki EmployeeID'nin sırasıdır
                    FirstName = item[1].ToString(), // [1] ifadesi sorgudaki FirstName'nin sırasıdır
                    LastName = item[2].ToString() // [1] ifadesi sorgudaki LastName'nin sırasıdır
                });
            }

            return _list;
        }

        public void Update(Employee entity)
        {
            var cmd = new SqlCommand("UPDATE Employees SET FirstName = @firstName, LastName = @lastName WHERE EmployeeID = @employeeId");
            cmd.Parameters.AddWithValue("firstName", entity.FirstName);
            cmd.Parameters.AddWithValue("lastName", entity.LastName);
            cmd.Parameters.AddWithValue("employeeId", entity.EmployeeID);

            RDMS.SqlNonQuery(cmd); // sql komutu çalıştırılır. etkilenen kayıt sayısı s değişkenine depolanır
        }
    }
}
