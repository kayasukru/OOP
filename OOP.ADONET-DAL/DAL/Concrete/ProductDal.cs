using OOP.ADONET_DAL.DAL.Abstract;
using OOP.ADONET_DAL.Entities;
using System.Data;
using System.Data.SqlClient;

namespace OOP.ADONET_DAL.DAL.Concrete
{
    public class ProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            var cmd = new SqlCommand("INSERT INTO Products(ProductName, UnitPrice, UnitsInStock) VALUES(@productName, @unitPrice, @unitsInStock)");
            cmd.Parameters.AddWithValue("productName", entity.ProductName);
            cmd.Parameters.AddWithValue("unitPrice", entity.UnitPrice);
            cmd.Parameters.AddWithValue("unitsInStock", entity.UnitsInStock);

            RDMS.SqlNonQuery(cmd); // sql komutu çalıştırılır. etkilenen kayıt sayısı s değişkenine depolanır

        }

        public void Delete(Product entity)
        {
            var cmd = new SqlCommand("DELETE FROM Products WHERE ProductId = @productId");
            cmd.Parameters.AddWithValue("productId", entity.ProductId);

            RDMS.SqlNonQuery(cmd); // sql komutu çalıştırılır. etkilenen kayıt sayısı s değişkenine depolanır
        }

        public List<Product> GetAll()
        {
            var _list = new List<Product>();

            var cmd = new SqlCommand("SELECT ProductId, ProductName, UnitPrice, UnitsInStock FROM Products");

            var ds = RDMS.SqlReader(cmd);

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                _list.Add(new Product()
                {
                    ProductId = int.Parse(item[0].ToString()), // [0] ifadesi sorgudaki EmployeeID'nin sırasıdır
                    ProductName = item[1].ToString(), // [1] ifadesi sorgudaki FirstName'nin sırasıdır
                    UnitPrice = decimal.Parse(item[2].ToString()), // [1] ifadesi sorgudaki LastName'nin sırasıdır
                    UnitsInStock = int.Parse(item[3].ToString()) // [1] ifadesi sorgudaki LastName'nin sırasıdır
                });
            }

            return _list;
        }

        public void Update(Product entity)
        {
            var cmd = new SqlCommand("UPDATE Products SET ProductName = @productName, UnitPrice = @unitPrice, UnitsInStock = @unitsInStock WHERE ProductId = @productId");
            cmd.Parameters.AddWithValue("productName", entity.ProductName);
            cmd.Parameters.AddWithValue("unitPrice", entity.UnitPrice);
            cmd.Parameters.AddWithValue("unitsInStock", entity.UnitsInStock);
            cmd.Parameters.AddWithValue("productId", entity.ProductId);

            RDMS.SqlNonQuery(cmd); // sql komutu çalıştırılır. etkilenen kayıt sayısı s değişkenine depolanır
        }
    }
}
