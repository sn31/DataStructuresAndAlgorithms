# Beep Boop Converter - Skye Nguyen

##### Epicodus - Independent Project Week 3 - 08/17/2018.

## Description

This is a web application that takes a number from a user and returns a range of numbers from 0 to the chosen number with the following exceptions:


> * Numbers that contain a 0 are replaced (all digits) with "Beep!"
> * Numbers that contain a 1 are replaced (all digits) with "Boop!"
> * Numbers divisible by 3 are replaced with "I'm sorry, Dave. I'm afraid I can't do that."


These exceptions are written from least to most important. The first exception should apply unless the second exception does, and the same with the second and third. So, for example, in your finished program, the number 10 should be replaced with "Boop!", and the number 30 should be replaced with "I'm sorry, Dave. I'm afraid I can't do that."

## Behavior-driven Development

| Specs    |  Input | Expected Output    
| ------------- |------------- |:-------------:|
| The program only allows number input for the Number field. | "fhwidn" | Please enter a number.
| This is a web application that takes a number from a user and returns a range of numbers from 0 to the chosen number with no exception.| 5 | 0, 1, 2, 3, 4, 5
| The program replace 0 with "Beep!" | 0 | "Beep!"
| The program replace 1 with "Boop!" | 1 | "Boop!"
| The program replace 3 with "I'm sorry, Dave. I'm afraid I can't do that." | 3 | "I'm sorry, Dave. I'm afraid I can't do that."
| The program replace numbers that contain a 0 with "Beep!" | 20 | "Beep!"
| The program replace numbers that contain a 1 with "Boop!" | 14 | "Boop!"
| The program replace numbers that are divisible by 3 (except 0) with "I'm sorry, Dave. I'm afraid I can't do that." | 30 | "I'm sorry, Dave. I'm afraid I can't do that."
| The program replace "Dave" in the output with the user's name for all numbers that are divisible by 3. | Name: Invoker Number: 30 | "I'm sorry, Invoker. I'm afraid I can't do that."
| The program return a descending string of numbers from n to 0 if the user select the "descending" radio.|Radio: Descending Number: 5 | 5, 4, 3, 2, 1, 0

## Setup/Installation Requirements

1. Clone this repository by using Terminal command:
```
    $ git clone https://github.com/sn31/beep-boop
```
2. Change into the work directory using Terminal command:
```
    $ cd beep-boop
```
3. Open the project in your preferred text editor.

4. To run the webpage, open it in a any browser.

## Known Bugs

None known in this version.

## Support and contact details

Please contact me at skye@dames.es for more information and/or feedback.

## Technologies Used

* Visual Studio Code
* HTML
* CSS
* Bootstrap v4.0.0
* JavaScript
* jQuery v3.3.1    
* Git
* GitHub

## Link to GitHub Pages

sn31.github.io/beep-boop

### License: MIT.

#### Copyright (c) 2018 Skye Nguyen


