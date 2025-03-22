using System;

class GenericClass<T>
{
    private T data;

    public GenericClass(T value)
    {
        data = value;
    }

    public void Display()
    {
        Console.WriteLine($"Value: {data}");
    }
}

class GenericMethodEx
{
    public void Show<T>(T item)
    {
        Console.WriteLine($"Item: {item}");
    }
}

class Program
{
    static void Main()
    {
        GenericClass<int> intObj = new GenericClass<int>(10);
        intObj.Display();

        GenericClass<string> stringObj = new GenericClass<string>("Hello");
        stringObj.Display();

        GenericMethodEx example = new GenericMethodEx();
        example.Show(100);
        example.Show("Generic Method");
        Console.ReadKey();
    }
}
