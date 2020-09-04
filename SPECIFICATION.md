# English Specification

_Requirements_: Triangle Tracker
Create a Triangle Tracker console application.

Make a console app with a Triangle class.

Use Console.ReadLine() to gather three numbers from the user.

Create a method in the Triangle class that takes these 3 numbers and returns what type of triangle (if any) they form:

Equilateral: All sides are equal;
Isosceles: Exactly 2 sides are equal;
Scalene: No sides are equal.
Not all combinations make valid triangles. If any side is longer than the other two sides combined, the lengths cannot form a triangle. For example, 2, 2, and 8 does not make a triangle. Make sure to account for this.

Write plain English spec descriptions first, including both an input and desired output for each test.

### _Tests & Functions_

* Class Triangle initializes with three integer side length values x, y, z, provides get for each.
* Class Triangle provides bool method .ValidTriangle(x,y,z) which checks each combination (x+y)/z > 1, (y+z)/x > 1, (z+x)/y > 1, returns false if not.
* .ValidTriangle is called at initialization on x, y, z inputs.
* Class Triangle exposes method .ofType() which returns a string "equilateral", "isosceles", or "scalene," depending on how many of the sides are equal.