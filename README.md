
# _TriangleTracker_
#### By _**Joshua Lovelace**_

## Description

_TriangleTracker details a class Triangle, which initializes with three integer side lengths X, Y, Z. These may be read with .X et al. The Triangle object exposes a method .OfType which will return whether the triangle is of type 'Equilateral,' 'Isosceles,' or 'Scalene,' (or 'Invalid' if sides don't form a triangle)._

## Setup/Installation Requirements

* Clone this repo.
* cd into the cloned repo and 'dotnet run.'
* Follow prompts to enter triangle side lengths.
* Be amazed by the mostly accurate response!

## Known Bugs

_Triangle side length validation is using integer division, so it will accept the edge case where two sides of a triangle exactly equal the third as valid (ie (X + Y) / Z = 1). Of course, this would essentially form a line, not a triangle._

## Support and contact details

rakmial@gmail.com

## Technologies Used

_C#, .NET, MSTest_

### License

Copyright (c) 2020 **_Joshua Lovelace_**
This software is licensed under the GNU GPL v3 license.