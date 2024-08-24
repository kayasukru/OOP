using OOP.Interface_GetEnumerate_App;

internal class Program
{
    private static void Main(string[] args)
    {
        var collection = new List<Product>()
        {
            new Product(){Id=1,ProductName="Buzdolabı",Price=2500},
            new Product(){Id=2,ProductName="Ocak",Price=500},
            new Product(){Id=3,ProductName="Kombi",Price=1500},
            new Product(){Id=4,ProductName="Televizyon",Price=3500},
            new Product(){Id=5,ProductName="Süpürge",Price=1000},
        };

        foreach (var product in collection)
        {
            Console.WriteLine($"{product.Id} {product.ProductName} {product.Price}");
        }

        Console.WriteLine(new string('-', 25));

        IEnumerator<Product> enumerator = collection.GetEnumerator();
        while (enumerator.MoveNext())
        {
            Console.WriteLine($"{enumerator.Current.Id} {enumerator.Current.ProductName} {enumerator.Current.Price}"); 
        }

    }
}