public class DiziStack : IStack
{
    public void Pop()
    {
        Console.WriteLine("Dizi.Pop()");
    }

    public void Push(int item)
    {
        Console.WriteLine("Dizi.Push()");
    }
}