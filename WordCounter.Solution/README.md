# Word Counter - Skye Nguyen

##### Epicodus Independent Project C# Week 1 - 09/07/2018.

## Description

This project contains the logic and tests for a word counter that checks how frequently a word appears in a given string. The user should input both the word and a list of words to check and only full word matches will be found.

## Behavior-driven Development

| Specs    |  Input | Expected Output    
| ------------- |------------- |:-------------:|
| The program should return an error message if the provided word include all non-alphabet characters. | Word: "#$!@"; String: "This string does not matter" | false
| The program should return an error message if the user did not provide a word| Word: "" ; String: "It's Friday!" | false
| The program should output 0 if the user does not provide a string of words. | Word: "cat"; String:""| 0
| The program should return 1 if the word and the string is the same, ignoring the case. | Word: "cat"; String: "cat" | 1
| The program should return the number of times the word appears in the string WITHOUT non-alphabet characters. | Word: "cat"; String: "I'm going to go to a cat cafe this weekend to find a fat cat." | 2
| The program should return the number of times the word appears in the string WITH non-alphabet characters. | Word: "cat"; String: "I'm going to go to a cat cafe this weekend to find a fat CAT! Because having a cat would be nice..." | 3

## Setup/Installation Requirements

1. Clone this repository:
```
    $ git clone https://github.com/sn31/WordCounter.Solution
```
2. Change into the work directory::
```
    $ cd WordCounter.Solution
```
3. To edit the project, open the project in your preferred text editor.

4. To run the program, first navigate to the location of the WordCounter.cs file then compile and execute:
```
    $ cd WordCounter/Models
    $ mcs WordCounter.cs; mono WordCounter.exe;
```
6. To run the tests, use these commands:
```
    $ cd WordCounter.Tests
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
