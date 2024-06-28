using System.Collections;

public class Dizi<T> : IEnumerable
{
    //private int[] InnerList;
    private T[] InnerList;
    private int index;

    public Dizi(int size = 16)
    {
        //InnerList = new int[16];
        InnerList = new T[16];
        index = 0;
    }

    //public Dizi(params int[] collection)
    public Dizi(params T[] collection)
    {
        //InnerList = new int[collection.Length];
        InnerList = new T[collection.Length];
        index = 0;
        foreach (var item in collection)
        {
            InnerList[index] = item;
            index++;
        }
    }

    public IEnumerator GetEnumerator()
    {
        return InnerList.Take(index).GetEnumerator();
    }
}
