using MoodAnalyserProblem;

namespace MoodAnalyserProblemTest
{
    public class Tests
    {
       
        [Test]

        public void GivenSadMood_ShouldReturnSad()
        {
            MoodAnalyserDemo moodAnalyserDemo = new MoodAnalyserDemo("Iam in sad mood");
            string result = moodAnalyserDemo.AnalyseMood();
            Assert.AreEqual(result, "sad");
        }
        [Test]
        public void GivenSadMood_ShouldReturnHappy()
        {
            MoodAnalyserDemo moodAnalyserDemo = new MoodAnalyserDemo("Iam in Any mood");
            string result = moodAnalyserDemo.AnalyseMood();
            Assert.AreEqual(result, "Happy");
        }
        
    }
}