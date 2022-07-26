# Point and Line 
## Case Study Scenario
A class called MyPoint, which models a 2D point with x and y coordinates, is designed
as shown in the class diagram.
It contains

    ● Two instance variables x (int) and y (int).
    ● A default (or "no-argument" or "no-arg") constructor that constructs a point at the default location of (0, 0).
    ● A parameterized constructor that constructs a point with the given x and y coordinates.
    ● Getter and setter for the instance variables x and y.
    ● A method setXY() to set both x and y.
    ● A method called distanceWithCords(int x, int y) that returns the distance from this point to another point at the given (x, y) coordinates.
    ● A method distanceWithObject(MyPoint another) that returns the distance from this point to the given MyPoint instance (called another).
    ● Another method distanceFromZero() method that returns the distance from this point to the origin (0,0)

A class called MyLine, which models a line with a begin point at (x1, y1) and an end
point at (x2, y2), is designed as shown in the class diagram. The MyLine class uses two
MyPoint instances (written in the earlier exercise) as its begin and end points. Write the
MyLine class. Also write a test driver to test all the public methods in the MyLine class.
Use distance formula to calculate the length of the line

## Domain Model
### Class name
![class name only](https://user-images.githubusercontent.com/96945594/180930290-3e372c2a-300d-4b8b-b71b-15e90f1451ca.jpg)
### Relations and Constraints
![constrain](https://user-images.githubusercontent.com/96945594/180930300-f8361997-94a1-45b2-8aed-5cf452d35480.jpg)
### Multiplicity
![mulitplicity](https://user-images.githubusercontent.com/96945594/180930310-9290289b-5b07-4e99-80d1-6453a694a5f5.jpg)

### Attributes and Function
#### Business Logic Layer
![bl](https://user-images.githubusercontent.com/96945594/180930642-7fb8f8b7-ec09-4ffc-b5b7-58868c79bcb3.JPG)
#### User Interfaces Layer
![ul](https://user-images.githubusercontent.com/96945594/180930649-1244f404-0b33-4328-8f74-877c3d39f272.JPG)
