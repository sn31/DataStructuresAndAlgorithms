# Clock Angle - Skye Nguyen

## Description

This app that determines the distance in degrees between the minute and hour hands on an analog clock, at a given time. It should use a Clock class with a method to take a time of day as input, and return the number of degrees for output. For example, 12 o'clock would return 0º and 6 o'clock would return 180º. Always return the smaller distance and be as precise as possible.

## Behavior-driven Development

| Specs    |  Input | Expected Output    
| ------------- |------------- |:-------------:|
| The program should return 0 degree for all 12 cases where the locations of the hour and the minute hands are the same.| 3:15 | 0
| The program should return the degrees between the hands for all hours.| 4:25 | 30

## Setup/Installation Requirements

1. Clone this repository:
```
    $ git clone https://github.com/sn31/ClockAngle.Solution
```
2. Change into the work directory::
```
    $ cd ClockAngle.Solution
```
3. To edit the project, open the project in your preferred text editor.

4. To run the program, first navigate to the location of the ClockAngle.cs file then compile and execute:
```
    $ cd ClockAngle/Models
    $ mcs ClockAngle.cs; mono ClockAngle.exe;
```
6. To run the tests, use these commands:
```
    $ cd ClockAngler.Tests
    $ dotnet test
```

## Known Bugs

None known in this version.

## Support and contact details

Please contact us at skye@dames.es for more information and/or feedback.

## Technologies Used

* Visual Studio Code
* C# FixFormat 0.0.71
* C#/.Net Core 1.1
* Mono
* Git
* GitHub

### License: MIT.

#### Copyright (c) 2018 Skye Nguyen
