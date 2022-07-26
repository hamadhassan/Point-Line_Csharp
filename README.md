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
