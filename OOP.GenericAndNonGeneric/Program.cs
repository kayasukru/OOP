internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Klasik Koleksiyon yapısı");
        var list1 = new LinkedList<int>();
        list1.AddFirst(3);
        list1.AddFirst(5);
        list1.AddFirst(7);
        list1.AddFirst(9);

        foreach (var item in list1)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        //Book sınıfı
        Console.WriteLine("Custom Class Generic yapısı");
        var list2 = new LinkedList<Book>();
        list2.AddFirst(new Book(1, "Safahat", 30));
        list2.AddFirst(new Book(2, "O ve Ben", 40));
        list2.AddFirst(new Book(3, "Aranan", 50));
        list2.AddFirst(new Book(4, "Gidenler", 60));

        foreach (var item in list2)
        {
            Console.WriteLine(item);
        }
    }
}
