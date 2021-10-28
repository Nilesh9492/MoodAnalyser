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
                if (message.Equals(string.Empty))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_EXCEPTION, "Mood should not be empty");
                }
                else if (message.ToLower().Contains("happy"))
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
                throw new CustomException(CustomException.ExceptionType.NULL_EXCEPTION, "Mood should not be null");
            }
        }

    }
}
