// Bir sınıfta abstract bir metod varsa sınıfın da ABSTRACT olması gerekir
// ABSTRACT sınıflardan bir nesne türetilemez
public class MinHeap : Heap
{
    public override int Extract()
    {
        var item = _list.Min;
        _list.Remove(item);
        return item;
    }
}
