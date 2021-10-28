using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
   public class MoodAnalyse
    {
        string message;
        public MoodAnalyse(string message)
        {
            this.message = message;
        }
        public string Mood()
        {
            try
            {
                if (message.ToLower().Contains("happy"))
                {
                    return "happy";
                }
                else
                {
                    return "sad";
                }
            }
            catch (NullReferenceException)
            {
                return "happy";
            }
        }

    }
}
