internal class Program
{
    private static void Main(string[] args)
    {
        var stack = new Stack<Company>();
        stack.Push(new Company()
        {
            Id = 1,
            Name = "Aselsan",
            Country="Türkiye"
        });

        Console.WriteLine(stack.Peek().Name);
    }
}
