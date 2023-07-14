using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    public class MoodAnalyserDemo
    {
        string message;
        public MoodAnalyserDemo(string message)
        {
                this.message = message;
        }
        public string AnalyseMood()
        {
            if (message.Contains("sad"))
            {
                return "sad";
            }
            else
            {
                return "Happy";
            }
        }
    }
}
