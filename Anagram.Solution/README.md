# Anagram

## Description

An anagram is a word that you can rearrange the letters and it becomes a new word. For example, "bread" is an anagram of "beard". 

This is a console app where a user can input a single word and a list of other words that may be anagrams. After submitting the form, the user should be told which of the list of words were anagrams.

## Behavior-driven Development

| Specs    |  Input | Expected Output    
| ------------- |------------- |:-------------:|
| The program should return an error message if the user does not supply both a word and a list of words | bear, {} | Please give a list of words.
| The program should determine if a word is an anagram of another word. | bread, {beard} | "Bear" is an anagram of "bread"
| The program should determine if a word is not an anagram of another word. | bread, {cat} | There is no anagram in this list.
| The program should determine if any words in a list is an anagram of the given word. | bread, {beard, cat, dog} | "beard" is an anagram of "bread"

## Setup/Installation Requirements

1. Clone this repository by using Terminal command:
```
    $ git clone https://github.com/sn31/Anagram.Solution
```
2. Change into the work directory using Terminal command:
```
    $ cd Anagram.Solution
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
