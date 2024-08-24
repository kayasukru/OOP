public class LinkedListedStack : IStack
{
    public void Pop()
    {
        Console.WriteLine("LinkedList.Pop()");
    }

    public void Push(int item)
    {
        Console.WriteLine("LinkedList.Push()");
    }
}