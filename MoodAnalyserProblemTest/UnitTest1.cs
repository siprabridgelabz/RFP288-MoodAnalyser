using MoodAnalyserProblem;

namespace MoodAnalyserProblemTest
{
    public class Tests
    {
        MoodAnalyserDemo moodAnalyserDemo = new MoodAnalyserDemo();
        [Test]

        public void GivenSadMood_ShouldReturnSad()
        {
            string result = moodAnalyserDemo.AnalyseMood("Iam in sad mood");
            Assert.AreEqual(result, "sad");
        }
    }
}