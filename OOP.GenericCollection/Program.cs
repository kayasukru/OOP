using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        // Bu yapıda aşağıdaki çarpma işleminin yapılması ancak cast işlemi ile olur
        // Bu işleme unboxing denir.
        var arrayList1 = new ArrayList();
        arrayList1.Add(1);
        arrayList1.Add("Mehmet");
        arrayList1.Add(true);

        foreach (var item in arrayList1)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine((int)arrayList1[0] * 10);
        Console.WriteLine();



        //Yukarıda casting işlemi ile unboxing yapılarak işlem yapılabilir.
        // Fakat bu durum tip güvenliğini korumaz
        // Bunun yerine aşağıdaki yapı kullanılabilir
        // Ama burada da her türlü veri tipi kolleksiyona dahil edilemez.
        // Aşağıdaki örnekte sadece int veri tipi eklendiği görülebilir.
        var arrayList2 = new List<int>();
        arrayList2.Add(1);
        arrayList2.Add('a'); // char karşılığı alınacağı için veri tipi yönünde hata vermez
        //arrayList2.Add(true);

        foreach (var item in arrayList2)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine((int)arrayList2[0] * 10);
    }
}