using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
namespace WordCounter.Tests
{
    [TestClass]
    public class WordCounterTest
    {
        [TestMethod]
        public void ValidityCheck_WordInputIsNonAlphabet_False()
        {
            string inputWord = "#$!@";
            Assert.IsFalse(RepeatCounter.ValidityCheck(inputWord));
        }

        [TestMethod]
        public void Validity_WordInputIsEmpty_False()
        {
            string inputWord = "";
            Assert.IsFalse(RepeatCounter.ValidityCheck(inputWord));
        }

        [TestMethod]
        public void Counter_StringInputIsEmpty_0()
        {
            string inputWord = "cat";
            string inputString = "";
            Assert.AreEqual(0,RepeatCounter.Counter(inputWord,inputString));
        }
        [TestMethod]
        public void Counter_SameStringAndWordInput_1()
        {
            string inputWord = "cat";
            string inputString = "cat";
            Assert.AreEqual(1,RepeatCounter.Counter(inputWord,inputString));
        }
        [TestMethod]
        public void Counter_ReturnNumberOfRepeats_2()
        {
            string inputWord = "cats";
            string inputString = "I love cats because cats are awesome cats dog cats";
            Assert.AreEqual(4,RepeatCounter.Counter(inputWord,inputString));
        }
        [TestMethod]
        public void Counter_ReturnNumberOfRepeatsWithNonAlphabet_4()
        {
            string inputWord = "cat";
            string inputString = "I'm going to go to a cat cafe this weekend to find a fat CAT! Because having a cat would be nice...";
            Assert.AreEqual(3,RepeatCounter.Counter(inputWord,inputString));
        }
    }
}