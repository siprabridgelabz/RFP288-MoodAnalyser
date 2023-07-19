using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MoodAnalyserProblem.MoodAnalyseCustom_Exception;

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
            try
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
            catch (NullReferenceException)
            {
                // return "Happy";
                throw new MoodAnalyseCustom_Exception("Message should not be null", MoodAnalyser_ExceptionType.NULL_MOOD);
            }
            
        }
    }
}
