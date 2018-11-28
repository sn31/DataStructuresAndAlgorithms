using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClockAngle.Models;

namespace ClockAngle.TestTools
{
    [TestClass]
    public class ClockAngleTest
    {
        [TestMethod]
        public void FindAngle_SameHandsLocation_string()
        {
            int hour = 3;
            int minute = 15;
            Assert.AreEqual("Distance between the hands is: 0",Clock.FindAngle(hour,minute));
        }
        [TestMethod]
        public void FindAngle_ReturnAngleBetweenHands_string()
        {
            int hour = 12;
            int minute = 15;
            Assert.AreEqual("Distance between the hands is: 90",Clock.FindAngle(hour,minute));
        }
        [TestMethod]
        public void ValidityCheck_InvalidTime_False()
        {
            int hour = 13;
            int minute = 60;
            Assert.IsFalse(Clock.ValidityCheck(hour,minute));
        }
    }
}

