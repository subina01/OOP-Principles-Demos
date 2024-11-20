 # Polymorphism

 Polymorphism is one of the principles of OOP that allows objects to take on multiple forms, enabling a single interface to represent different underlying data types. 

 Polymorphism in C# can be achieved through:

- Compile-Time Polymorphism **(Method Overloading)**:
  A class can define multiple methods with the same name but different parameters.
  The decision of which method to invoke is made at compile time.

- Run-Time Polymorphism **(Method Overriding)**:
  Allows a derived class to modify or extend the behavior of a method in its base class.
  The decision of which method to invoke is made at runtime using the virtual and override keywords.


  ## Types

### Compile-Time Polymorphism
     Achieved using method overloading in the Vehicle class:
- - Start(string vehicleType): Starts the vehicle with a name.
- - Start(string vehicleType, int speed): Starts the vehicle with a name and speed.
	- 
### Run-Time Polymorphism
    Achieved using method overriding in the vehicle class:

- - FuelType() in the Vehicle class is declared as virtual.
- - Derived classes (Car, Truck) override this method to provide specific functionality.

## Expected Output


- - - truck is starting.
- - - car is starting with speed 60
- - - Car uses petrol as fuel.