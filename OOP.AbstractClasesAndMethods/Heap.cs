// Bir sınıfta abstract bir metod varsa sınıfın da ABSTRACT olması gerekir
// ABSTRACT sınıflardan bir nesne türetilemez
using System.Collections.Generic;

public abstract class Heap
{
    // field
    // Miras verren sınıftaki fieldlar private ise miras alan sınıfta geçersizdir.
    // private yerine protected ifadesi verilirse, miras alan devralabilir.
    //private SortedSet<int> _list;
    protected SortedSet<int> _list;

    public Heap()
    {
        _list = new SortedSet<int>();
    }

    public void Insert(int item)
    {
        _list.Add(item);
    }

    //abstract metod
    //Bir sınıfta abstract bir metod varsa sınıfın da ABSTRACT olması gerekir

    //Miras alan sınıf üzerinden metodlar implement edildiğinde miras alan sınıftaki metodun override yapılması gerekir
    public abstract int Extract();
}
