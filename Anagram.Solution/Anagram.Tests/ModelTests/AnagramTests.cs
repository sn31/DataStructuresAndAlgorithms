using System;
using System.Collections.Generic;
using Anagram.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Anagram.Tests
{
    [TestClass]
    public class AnagramTest
    {
        [TestMethod]
        public void AnagramFinder_AskUserToEnterCorrectInput_String()
        {
            string mainWord = "";
            List<string> wordList = new List<string> { "cat", "beard" };
            AnagramChecker newAnagram = new AnagramChecker(mainWord, wordList);
            string result = newAnagram.AnagramFinder();
            Assert.AreEqual("Please provide both a word and a list of words.", result);
        }

        [TestMethod]
        public void AnagramFinder_FindAnagramInListOfOneElement_String()
        {
            string mainWord = "bread";
            List<string> wordList = new List<string> { "beard" };
            AnagramChecker newAnagram = new AnagramChecker(mainWord, wordList);
            string result = newAnagram.AnagramFinder();
            Assert.AreEqual("Anagram found: beard", result);
        }
        [TestMethod]
        public void AnagramFinder_FindAnagramInListOfTwoElement_String()
        {
            string mainWord = "bread";
            List<string> wordList = new List<string> { "beard","cat","eardb" };
            AnagramChecker newAnagram = new AnagramChecker(mainWord, wordList);
            string result = newAnagram.AnagramFinder();
            Assert.AreEqual("Anagram found: beard eardb", result);
        }
    }
}