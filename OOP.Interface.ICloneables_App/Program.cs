using OOP.Interface.ICloneables_App;

internal class Program
{
    private static void Main(string[] args)
    {
        // ICloneable uygulanmadan çoğaltma
        Console.WriteLine("ICloneable uygulanmadan çoğaltma");
        var book1 = new Book()
        {
            Id = 1,
            Title = "Suç ve Ceza",
            Price = 10.50M
        };

        var book2 = book1;
        book2.Id = 2;
        book2.Title = "Sefiller";
        book2.Price = 10.30M;
        Console.WriteLine(book1.Id + " " + book1.Title + " " + book1.Price);
        Console.WriteLine(book2.Id + " " + book2.Title + " " + book2.Price);
        Console.WriteLine();

        //ICloneable uygulayarak çoğaltma
        Console.WriteLine("ICloneable uygulayarak çoğaltma");
        var book3 = new Book()
        {
            Id= 1,
            Title = "Safahat",
            Price= 50.60M
        };
        var book4 = (Book)book3.Clone();
        book4.Id = 2;
        book4.Title = "O ve Ben";
        book4.Price = 20.80M;
        Console.WriteLine(book3.Id + " " + book3.Title + " " + book3.Price);
        Console.WriteLine(book4.Id + " " + book4.Title + " " + book4.Price);
    }
}