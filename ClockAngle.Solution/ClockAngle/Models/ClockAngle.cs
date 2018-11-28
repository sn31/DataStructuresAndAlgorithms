using System;
using System.Linq;
namespace ClockAngle.Models
{
    public class Clock
    {
        public static bool ValidityCheck(int hour, int minute)
        {
            if (hour > 12 || hour < 0 || minute > 59 || minute < 0)
            {
                return false;
            }
            return true;
        }
        public static string FindAngle(int hour, int minute)
        {
            if (ValidityCheck(hour, minute))
            {
                int hourLocation = hour * 5;
                int degreeDiff = Math.Abs(hourLocation - minute) * 6;
                int result = (degreeDiff > 180) ? (360 - degreeDiff) : degreeDiff;
                return "Distance between the hands is: " + result;
            }
            return "Please enter a valid time!";
        }
    }
}