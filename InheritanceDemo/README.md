# Inheritance
It is one of the principle of OOP which allows a class (called the child class or subclass) to inherit properties and methods from another class (called the parent class or superclass).

## OverView

The InheritanceDemo program demonstrates the concepts of object-oriented programming (OOP)
in C#, particularly focusing on inheritance. It implements a base class Vehicle and several
derived classes, such as Car, SportsCar, and Truck. The program shows examples of single 
inheritance, multi-level inheritance, and hierarchical inheritance.

## Types


### Vehicle (Base Class)

-  Vehicle class serves as the parent class for both Car and Truck. It contains:

 - DisplayInfo(): Displays the company name and model of the vehicle.
 - StartEngine(): A virtual method that prints a message indicating the vehicle engine 
   has started. It can be overridden in derived classes.

### Car (Single Inheritance)

The Car class inherits from Vehicle and represents a basic car. It adds the following:

 - DisplayCarDetails(): Displays details about the car, including the company, model, and color.
 - StartEngine(): Overrides the StartEngine() method from Vehicle to display a message specific to a car engine.

### SportsCar (Multi-Level Inheritance)

The SportsCar class inherits from Car, demonstrating multi-level inheritance. It represents 
a high-performance sports car with the following:

- DisplaySportsCarDetails(): Displays details about the sports car, including company, 
   model, color, and  speed.
- Inherits DisplayCarDetails() and StartEngine() from Car.

### Truck (Hierarchical Inheritance)
The Truck class inherits from Vehicle, demonstrating hierarchical inheritance, where multiple subclasses (like Car and Truck) share the same parent class. 
It represents a truck with the following:

 - DisplayTruckDetails(): Displays details about the truck, including company, model, and load capacity.
 - StartEngine(): Overrides the StartEngine() method from Vehicle to display a message specific to a truck engine.

 ### Expected Outcome

- - - - companyName: SpaceX Model: i10
- - - - Vehicle engine started.

- - - - companyName: Tesla Model: 123
- - - - color of car is = red
- - - - Car engine started ...

- - - - companyName: Tesla Model: 123
- - - - LoadCapacity = 1000 tons
- - - - Truck engine started ....

- - - - companyName: Ferrari Model: 488
- - - - color of car is = blue
- - - - Top Speed: 211 mph
- - - - Car engine started ...