using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoodAnalyserProblem;

namespace MoodAnalyserProblemTest
{
    public  class MoodAnalyserTest
    {
        MoodAnalyserDemo moodAnalyserDemo  = new MoodAnalyserDemo();
        [Test]

        public void GivenSadMood_ShouldReturnSad()
        {
            string result = moodAnalyserDemo.AnalyseMood("Iam in sad mood");
            Assert.AreEqual(result, "sad");
        }

    }
}
