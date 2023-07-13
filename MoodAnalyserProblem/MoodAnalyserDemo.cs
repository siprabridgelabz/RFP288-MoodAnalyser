using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    public class MoodAnalyserDemo
    {
        public string AnalyseMood(string message)
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
