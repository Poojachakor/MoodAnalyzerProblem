namespace MoodAnalyserProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                string mood = string.Empty;
                MoodAnalyserClass moodAnalyser = new MoodAnalyserClass(mood);
                string result = moodAnalyser.AnalyseMood();
                Console.WriteLine(result);
            }
            catch (MoodAnalysisException m)
            {
                Console.WriteLine(m.Message);
            }
        }


    }
    
}
