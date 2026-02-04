namespace DesignPatterns;

public class MyClass

{
    private int _value;

    public MyClass(int value)
    {
        _value = value;
    }

    public void PrintValue()
    {
        Console.WriteLine("Value= "+ _value);
    }
}