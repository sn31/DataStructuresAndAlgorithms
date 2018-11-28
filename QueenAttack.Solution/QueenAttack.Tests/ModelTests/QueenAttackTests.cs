using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueenAttack;

namespace QueenAttack.TestTools
{
    [TestClass]
    public class QueenAttackTest
    {
        [TestMethod]
        public void CanAttack_SameCoordinatePairs_False()
        {
            Queen testQueen = new Queen(2,4,2,4);
            Assert.IsFalse(testQueen.CanAttack());
        }
        [TestMethod]
        public void CanAttack_Horizontally_True()
        {
            Queen testQueen = new Queen(2,4,2,8);
            Assert.IsTrue(testQueen.CanAttack());
        }
        [TestMethod]
        public void CanAttack_Vertically_True()
        {
            Queen testQueen = new Queen(2,4,7,4);
            Assert.IsTrue(testQueen.CanAttack());
        }
        [TestMethod]
        public void CanAttack_Diagonally_True()
        {
            Queen testQueen = new Queen(1,1,0,2);
            Assert.IsTrue(testQueen.CanAttack());
        }
    }
}