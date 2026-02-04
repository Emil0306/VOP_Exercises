# Facade Pattern

Imagine you're designing a software system for a car simulator. You have separate classes for various car subsystems:

* Engine: Controls the engine (start/stop, accelerate, decelerate).
* Brakes: Controls the braking system (apply brakes, release brakes).
* Steering: Controls the steering wheel (turn left, turn right).
* **Note:** All the above classes are provided in the `Facade` directory. Please take a look.


## Your Task:
Your task is to create a facade class called `CarFacade` that simplifies the interaction with these subsystems. The facade should provide the following functionalities:
* Create a `CarFacade` class that acts as a facade for the Engine, Brakes, and Steering classes and encapsulate the logic of interacting with the underlying components.
* The `CarFacade` class should provide methods to `start`, `stop`, `brake`, `accelerate`, `decelerate` and `steer` the car.
    * Start(): Starts the car (start engine).
    * Stop(): Stops the car (decelerate engine, apply brakes and stop engine).
    * Brake(): Applies the brakes.
    * Accelerate(): Accelerates the engine (increase engine throttle).
    * Decelerate(): Decelerates the engine (decrease engine throttle).
    * Steer(direction): Steers the car in the given direction (left or right).
* Now that you have implemented the `CarFacade` class, it's time to test it out!
* Use `Program.cs` to demonstrate  how the facade pattern can be used to hide the complexity of the underlying system and provide a simpler interface for clients. This is the entry point of your console application.
* **Create a `CarFacade` object:** Instantiate an object of the `CarFacade` class.
* **Use the facade methods:** Call the methods of the `CarFacade` object to demonstrate its functionalities.
    *   Start the car (`Start()`).
    *   Accelerate (`Accelerate()`).
    *   Steer left (`Steer("left")`).
    *   Stop the car (`Stop()`).

**Example Output:**


    Engine started.
    Engine Accelerated.
    Turning left.
    Engine Decelerated.
    Brakes applied.
    Engine stopped.
