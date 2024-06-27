// Bir sınıfta abstract bir metod varsa sınıfın da ABSTRACT olması gerekir
// ABSTRACT sınıflardan bir nesne türetilemez
public class MaxHeap : Heap
{
    public override int Extract()
    {
        var item = _list.Max;
        _list.Remove(item);
        return item;
    }
}