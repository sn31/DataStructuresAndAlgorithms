using System;
using System.Collections.Generic;

public class Triangle {
    public int sideOne;
    public int sideTwo;
    public int sideThree;
    public bool IsTriangle (int sideOne, int sideTwo, int sideThree) {
        if (sideOne > (sideTwo + sideThree) || sideTwo > (sideOne + sideThree) || sideThree > (sideOne + sideTwo)) {
            return false;
        } else {
            return true;
        }
    }
    public string typeOfTriangle (int sideOne, int sideTwo, int sideThree) {
        if ((sideOne == sideTwo) && (sideOne == sideThree)) {
            return "equilateral";
        } else if ((sideOne == sideTwo) || (sideOne == sideThree) || (sideTwo == sideThree)) {
            return "isosceles";
        } else {
            return "scalene";
        }
    }
}
class Program {
    public static void Main () {
        Console.WriteLine ("Please enter three sides of the triangle separated by commas: "); //"2,3,4"
        string[] sides = Console.ReadLine ().Split (','); //["2","3","4"]
        List<int> sidesList = new List<int> { };
        foreach (string side in sides) {
            sidesList.Add (int.Parse (side));
        }
        Triangle myTriangle = new Triangle ();
        if (myTriangle.IsTriangle (sidesList[0], sidesList[1], sidesList[2])) {
            Console.WriteLine ("This is a " + myTriangle.typeOfTriangle (sidesList[0], sidesList[1], sidesList[2]) + " triangle!");
        } else {
            Console.WriteLine ("You did not make a triangle!");
        }
    }
}