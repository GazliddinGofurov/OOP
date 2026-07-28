class GenericClass<T>
{
    private T data;

    public GenericClass(T value)
    {
        data = value;
    }

    public void Display()
    {
        Console.WriteLine($"\nValue: {data} - {data.GetType()}");
    }
}

// Generic Class with two parameters
class Pair <T1, T2>
{
    public T1 First {get; set;}
    public T2 Second {get; set;}

    public Pair (T1 first, T2 second)
    {
        First = first;
        Second =  second;
    }

    // Methods to display
    public void Display()
    {
        Console.WriteLine($"\nFirst: {First} Second: {Second} ");
    }
}

