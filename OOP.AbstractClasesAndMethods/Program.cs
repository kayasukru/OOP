internal class Program
{
    private static void Main(string[] args)
    {
        // Bir dizideki en küçük ve en büyük sayıları bulma

        var dizi = new int[] { 10, 2, 9, 3, 4, 5, 1, 6, 7 };

        // ABSTRACT sınıflardan bir nesne türetilemez
        // Bir başka sınıf
        // var heap = new Heap(); 
        var minHeap = new MinHeap();
        var maxHeap = new MaxHeap();

        foreach (var item in dizi)
        {
            minHeap.Insert(item);
            maxHeap.Insert(item);
        }

        Console.Write ("Dizi: { ");
        foreach (var s in dizi)
        {
            Console.Write( s + " " );
        }
        Console.Write(" }");
        Console.WriteLine();
        Console.WriteLine("Dizideki en küçük sayı : " + minHeap.Extract()); // 1 döner
        Console.WriteLine("Dizideki en büyük sayı : " + maxHeap.Extract()); // 10 döner
    }
}
