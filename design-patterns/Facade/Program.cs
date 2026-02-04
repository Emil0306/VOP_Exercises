using Facade;

class Program
{
    static void Main(string[] args)
    {
        CarFacade car = new CarFacade();
        car.Start();
        car.Accelerate();
        car.Steer("left");
        car.Stop();
    }
}