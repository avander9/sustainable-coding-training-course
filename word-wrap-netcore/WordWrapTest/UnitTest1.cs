using Word_Wrap;

namespace WordWrapTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod("When the word is empty should do nothing")]
        public void TestMethod1()
        {
            string word = "";
            int width = 2;
            string spectedWrapedWord = word;

            var wrapedWord = new BestWordWrapEver().WrapWord(word, width);

            Assert.IsTrue(spectedWrapedWord == wrapedWord.Word);
            Assert.IsTrue(string.IsNullOrWhiteSpace(wrapedWord.Warning));
        }

        [TestMethod("When the width is less than zero should return warning")]
        public void TestMethod2()
        {
            string word = "Hola";
            int width = -2;
            string spectedWrapedWord = word;

            var wrapedWord = new BestWordWrapEver().WrapWord(word, width);

            Assert.IsTrue(spectedWrapedWord == wrapedWord.Word);
            Assert.IsTrue(wrapedWord.Warning == "Width should be greater than zero");
        }

        [TestMethod("When the word lenth is shortest or equals width should do nothing")]
        public void TestMethod3()
        {
            string word = "Hola";
            int width = 5;
            string spectedWrapedWord = word;

            var wrapedWord = new BestWordWrapEver().WrapWord(word, width);

            Assert.IsTrue(spectedWrapedWord == wrapedWord.Word);
            Assert.IsTrue(string.IsNullOrWhiteSpace(wrapedWord.Warning));
        }

        [TestMethod("When the word lenth match width should do nothing")]
        public void TestMethod5()
        {
            string word = "Lean Mind";
            int width = 10;
            string spectedWrapedWord = word;

            var wrapedWord = new BestWordWrapEver().WrapWord(word, width);

            Assert.IsTrue(spectedWrapedWord == wrapedWord.Word);
            Assert.IsTrue(string.IsNullOrWhiteSpace(wrapedWord.Warning));
        }

        //[TestMethod("The word 'hola' should be splited like this 'ho la'")]
        //public void TestMethod1()
        //{
        //    string word = "hola";
        //    int width = 2;

        //    var wrapedWord = new BestWordWrapEver().WrapWord(word, width);

        //    Assert.Equals("ho \nla", wrapedWord);
        //}
    }
}