namespace DesignPatterns;

public class MyClass

{
    private static MyClass SingletonPattern = new MyClass(10);
    
    private int _value;

    private MyClass(int value)
    {
        _value = value;
    }

    public static MyClass GetInstance()
    {
        return SingletonPattern;
    }

    public void PrintValue()
    {
        Console.WriteLine("Value= "+ _value);
    }
}