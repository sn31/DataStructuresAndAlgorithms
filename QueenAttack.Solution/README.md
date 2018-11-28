# Queen Attack Game

## Description

In chess, a queen can move horizontally, vertically, and diagonally, making it the most powerful piece on the board. If another piece is within its line of sight along these three lines, then the queen can attack it.

This is an app where the user can enter an X and a Y coordinate for the queen, and an X and a Y coordinate for another chess piece which the queen is attacking.


## Behavior-driven Development

| Specs    |  Input | Expected Output    
| ------------- |------------- |:-------------:|
| There cannot be two pieces on the same coordinate. |Queen: [2,4] & Other: [2,4]| false
| The queen can attack if her X coordinate is the same as the other piece's X coordinate.| Queen: [3,5] & Other: [3,8] | true
| The queen can attack if her Y coordinate is the same as the other piece's Y coordinate.| Queen: [2,5] & Other: [3,5] | true
| The queen can attack diagonally.| Queen: [4,3] & Other: [3,4] | true


## Setup/Installation Requirements

1. Clone this repository by using Terminal command:
```
    $ git clone https://github.com/sn31/QueenAttack.Solution
```
2. Change into the work directory using Terminal command:
```
    $ cd QueenAttack.Solution
```
3. Open the project in your preferred text editor.


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
