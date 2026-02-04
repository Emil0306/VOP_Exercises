using DesignPatterns;

class Program
{
    static void Main(string[] args)
    {
        MyClass mc = MyClass.GetInstance();
        mc.PrintValue();
    }
}