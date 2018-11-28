# Leetspeak Translator

## Description

Leetspeak uses an alternative alphabet of numbers and symbols to replace various letters in words. For example, "leet" becomes "1337" and "Epicodus" might become "3p1c0duz".

This translator converts a string into a simple version of Leetspeak using the following rules:

* The letter "e" should be replaced with "3".
* The letter "o" should be replaced with "0".
* The capital letter (not the lower case), "I", should be replaced with "1".
* The letter "t" should be replaced with "7".
* All instances of "s" should be replaced with "z" UNLESS it is the first letter of the word.

## Behavior-driven Development

| Specs    |  Input | Expected Output    
| ------------- |------------- |:-------------:|
| Only letter "e" should be replaced with "3".| leet | l33t
| The letter "o" should be replaced with "0". | poet | p03t
| The capital letter (not the lower case), "I", should be replaced with "1".| Item | 1t3m
| The letter "t" should be replaced with "7".| Item | 173m
| All instances of "s" should be replaced with "z" UNLESS it is the first letter of the word.|success| succ3zz
| A sentence should be translated using all of the rules above.|Don't you love these 'String' exercises? I do!| D0n'7 y0u l0v3 7h3z3 'S7ring' 3x3rciz3z? 1 d0!


## Setup/Installation Requirements

1. Clone this repository by using Terminal command:
```
    $ git clone https://github.com/sn31/Leetspeak.Solution
```
2. Change into the work directory using Terminal command:
```
    $ cd Leetspeak.Solution
```
3. Open the project in your preferred text editor.

4. To run the webpage, open it in a any browser.

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
