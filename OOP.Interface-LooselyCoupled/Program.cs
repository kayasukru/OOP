using OOP.Interface_LooselyCoupled;

internal partial class Program
{
    private static void Main(string[] args)
    {
        var stack = new Stack(new DiziStack());

        stack.Pop();
        stack.Push(5);
    }
}