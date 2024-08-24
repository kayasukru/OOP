using OOP.GenericRepositoryDesignPattern.Entities.Abstract;

namespace OOP.GenericRepositoryDesignPattern.Entities.Concrete
{
    public class Product : IEntity
    {
        public Product()
        {
            
        }
        public Product(int productId, string productName, decimal price, int unitsInStock)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
            UnitsInStock = unitsInStock;
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int UnitsInStock { get; set; }
    }
}
