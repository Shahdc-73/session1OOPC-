# Assignment 5 - Enum and Struct in C#

This repository contains solutions for Assignment 5, which focuses on using `Enum` and `Struct` in C#. The assignment involves tasks such as creating and using enums for weekdays, seasons, colors, and permissions, as well as working with structs to represent persons and points.

## Tasks:

### Task 1: Enum for WeekDays
- Create an enum called `WeekDays` with the days of the week (Monday to Sunday) as its members.
- Write a C# program that prints out all the days of the week using this enum.

### Task 2: Struct for Person
- Define a struct `Person` with properties `Name` and `Age`.
- Create an array of three `Person` objects and populate it with data.
- Write a C# program to display the details of all the persons in the array.

### Task 3: Enum for Season
- Create an enum called `Season` with the four seasons (Spring, Summer, Autumn, Winter) as its members.
- Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season.
  - **Spring**: March to May
  - **Summer**: June to August
  - **Autumn**: September to November
  - **Winter**: December to February

### Task 4: Permissions Enum and Management
- Assign the following permissions (Read, Write, Delete, Execute) in a form of an enum.
- Create a variable from the previous enum to add and remove permissions.
- Check if a specific permission exists inside the variable.

### Task 5: Enum for Colors
- Create an enum called `Colors` with the basic colors (Red, Green, Blue) as its members.
- Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.

### Task 6: Struct for Point and Distance Calculation
- Create a struct called `Point` to represent a 2D point with properties `X` and `Y`.
- Write a C# program that takes two points as input from the user and calculates the distance between them.

### Task 7: Oldest Person in Array
- Create a struct called `Person` with properties `Name` and `Age`.
- Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.

## File Structure:
- `Program.cs`: Contains the implementation for all tasks.
- `PersonNamespace`: Contains the definition of the `Person` struct used in various tasks.
- `PointNamespace`: Contains the definition of the `Point` struct.

## Instructions:
1. Clone the repository to your local machine.
2. Open the solution in Visual Studio or Visual Studio Code.
3. Run the `Program.cs` file to execute the tasks.
4. The program will display outputs for each task.

## Example Output:
- **WeekDays Enum**: Displays the names of the days of the week.
- **Season Enum**: Takes user input for the season and displays the corresponding month range.
- **Permissions Enum**: Manages permissions using bitwise operations (add/remove/check).
- **Colors Enum**: Takes user input for a color and checks if it is a primary color.

## Technologies Used:
- C#
- Visual Studio / Visual Studio Code
- .NET Framework

## License:
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

