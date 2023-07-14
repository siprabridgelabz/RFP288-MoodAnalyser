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
       
        [Test]

        public void GivenSadMood_ShouldReturnSad()
        {
            MoodAnalyserDemo moodAnalyserDemo = new MoodAnalyserDemo("Iam in Sad mood");
            string result = moodAnalyserDemo.AnalyseMood();
            Assert.AreEqual(result, "sad");
        }

        [Test]
        public void GivenSadMood_ShouldReturnHappy()
        {
            MoodAnalyserDemo moodAnalyserDemo = new MoodAnalyserDemo("I am in Any mood");
            string result = moodAnalyserDemo.AnalyseMood();
            Assert.AreEqual(result, "Happy");
        }


    }
}
