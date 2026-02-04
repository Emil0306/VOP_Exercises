namespace Facade;

public class CarFacade
{
    Brakes brakes;
    Engine engine;
    Steering steering;

    public CarFacade()
    {
        brakes = new Brakes();
        engine = new Engine();
        steering = new Steering();
    }
    
    public void Start()
    {
        engine.Start();
    }
    public void Stop()
    {
        engine.Decelerate();
        brakes.Apply();
        engine.Stop();
    }
    public void Brake()
    {
        brakes.Apply();
    }
    public void Accelerate()
    {
        engine.Accelerate();
    }
    public void Decelerate()
    {
        engine.Decelerate();
    }
    public void Steer(string direction)
    {
        switch (direction.ToLower())
        {
            case "left":
                steering.TurnLeft();
                break;
            case "right":
                steering.TurnRight();
                break;
        }
    }
}