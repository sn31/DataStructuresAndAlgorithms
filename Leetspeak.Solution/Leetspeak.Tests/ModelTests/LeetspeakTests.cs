using Translator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Translator.Tests
{
    [TestClass]
    public class LeetspeakTranslatorTest
    {
        [TestMethod]
        public void Translate_ReplaceLetterEWithThree_L33()
        {
            LeetspeakTranslator testLeetspeak = new LeetspeakTranslator();
            Assert.AreEqual("l33", testLeetspeak.Translate("lEe"));
        }
        [TestMethod]
         public void Translate_ReplaceLetterOWith0_p03m()
        {
            LeetspeakTranslator testLeetspeak = new LeetspeakTranslator();
            Assert.AreEqual("p03m", testLeetspeak.Translate("pOEm"));
        }
        [TestMethod]
        public void Translate_ReplaceLetterIWith1_1g3m()
        {
            LeetspeakTranslator testLeetspeak = new LeetspeakTranslator();
             Assert.AreEqual("1g3m", testLeetspeak.Translate("Igem"));
        }
        [TestMethod]
        public void Translate_ReplaceLetterTWith7_173m()
        {
            LeetspeakTranslator testLeetspeak = new LeetspeakTranslator();
             Assert.AreEqual("173m", testLeetspeak.Translate("Item"));
        }
        [TestMethod]
        public void Translate_AllBehaviors_s173m0zz3()
        {
            LeetspeakTranslator testLeetspeak = new LeetspeakTranslator();
             Assert.AreEqual("s173m0zz3", testLeetspeak.Translate("sItemosse"));
        }
        [TestMethod]
        public void Translate_AllBehaviorsSentence_FinalOutput()
        {
            LeetspeakTranslator testLeetspeak = new LeetspeakTranslator();
             Assert.AreEqual("D0n'7 y0u l0v3 7h3z3 'S7ring' 3x3rciz3z? 1 d0!", testLeetspeak.Translate("Don't you love these 'String' exercises? I do!"));
        }
    }
}