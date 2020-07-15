
# _Triangle Tracker_

#### _Triangle Tracker Project July 14, 2020_

#### By _**Joseph Pearce and Beverly Potts**_

## Description

_A project to introduce the C# language and the .NET Core framework. Create a Triangle class that takes 3 numbers and returns what type of triangle it is. The lesson is meant to practice creating automated testing methods using MSTest._

### Specs
| Spec | Input | Output |
| :------------- | :------------- | :------------- |
| **Triangles with three equivalent sides are equilateral** | User Input:”Side 1: 3, Side 2: 3, Side 3: 3” | Output: "Equilateral" |
| **Triangles with two equivalent sides are isosceles** | User Input:”Side 1: 3, Side 2: 3, Side 3: 2” | Output: "Isosceles" |
| **Triangles with no equivalent sides are isosceles** | User Input:”Side 1: 3, Side 2: 2, Side 3: 4” | Output: "Scalene" |
| **Triangles with two sides that add up to less than the value of the third side are invalid** | User Input:”Side 1: 3, Side 2: 2, Side 3: 7” | Output: "Invalid" |

## Setup/Installation Requirements

1. Clone this repository from GitHub.
2. Open the downloaded directory in a text editor of your choice.
  (VSCode, Atom, etc.)
3. To install the REPL dotnet script, run dotnet tool install -g dotnet-script in your terminal.
4. Run the program with the command dotnet build.

## Known Bugs

There are no known bugs at the time of this update.
 

## Technologies Used

* C#
* .NET Core
* Git and GitHub


### License

This software is licensed under the MIT license.

Copyright (c) 2020 **_Joseph Pearce, Beverly Potts_**