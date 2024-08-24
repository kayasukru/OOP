using OOP.GenericConstraints;

internal class Program
{
    private static void Main(string[] args)
    {
        var arr1 = new Dizi<Book>(
            new Book(1, "Hayat ve Hatıratım", 51.51M),
            new Book(2, "Dün ve Bugün", 43.52M),
            new Book(3, "Dün ve Ötesi", 64.54M),
            new Book(4, "Yarınlar ve Bugünler", 75.89M)
            );

        Console.WriteLine("Kitap listesi");
        foreach (var item in arr1)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        //Aşağıdaki yapıda, Dizi sınıfı sınırlandırmalı olduğu ve Company bir struct olduğu için Company hata verir
        /*
        var arr2 = new Dizi<Company>(
            new Company() { Id=1, Name="Aselsan", Country="Türkiye"},
            new Company() { Id=2, Name="Roketsan", Country="Azerbaycan"},
            new Company() { Id=3, Name="Havelsan", Country="Pakistan"},
            new Company() { Id=4, Name="Baykar", Country="Ukrayna"},
            new Company() { Id=5, Name="FNSS", Country="Katar"}
            );

        Console.WriteLine("Şirket listesi");
        foreach (var item in arr2)
        {
            Console.WriteLine(item);
        }
        */
    }
}