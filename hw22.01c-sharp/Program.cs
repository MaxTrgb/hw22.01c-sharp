class Program
{
    public static void Main(string[] args)
    {
        Stack<int> intStack = new Stack<int>();
        intStack.Push(1);
        intStack.Push(2);
        intStack.Push(3);

        Console.WriteLine("Top element: " + intStack.Peek());
        Console.WriteLine("Popped element: " + intStack.Pop());
        Console.WriteLine("Top element after pop: " + intStack.Peek());

        Stack<string> stringStack = new Stack<string>();
        stringStack.Push("Hello");
        stringStack.Push("World");

        Console.WriteLine("Top element: " + stringStack.Peek());
        Console.WriteLine("Popped element: " + stringStack.Pop());
    }
}