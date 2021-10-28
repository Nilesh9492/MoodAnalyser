using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        MoodAnalyse moodAnalyser;
        string message = " I am happy";
        [TestInitialize]
        public void SetUp()
        {
            moodAnalyser = new MoodAnalyse(message);
        }
        [TestMethod]
        public void TestMethod1()
        {
            string expected = "happy";

            string actual = moodAnalyser.Mood();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string expected = "sad";
            moodAnalyser = new MoodAnalyse("I am sad");
            string actual = moodAnalyser.Mood();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodNull()
        {
            string expected = "happy";
            MoodAnalyse moodAnalyser = new MoodAnalyse("I am happy");
            string actual = moodAnalyser.Mood();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodCustomNullException()
        {
            string expected = "Mood should not be null";
            try
            {

                MoodAnalyse moodAnalyser = new MoodAnalyse(null);
                moodAnalyser.Mood();
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestMethod]
        public void TestMethodForCustomizedEmptyException()

        {
            string expected = "Mood should not be empty";
            try
            {

                MoodAnalyse moodAnalyser = new MoodAnalyse(string.Empty);
                moodAnalyser.Mood();
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}
