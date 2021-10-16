namespace DependencyParser
{
    public class ParserEvaluationScore
    {
        private double LAS;
        private double UAS;
        private double LS;
        private int wordCount;

        public ParserEvaluationScore()
        {
        }

        public ParserEvaluationScore(double LAS, double UAS, double LS, int wordCount)
        {
            this.LAS = LAS;
            this.UAS = UAS;
            this.LS = LS;
            this.wordCount = wordCount;
        }

        public double GetLS()
        {
            return LS;
        }

        public double GetLAS()
        {
            return LAS;
        }

        public double GetUAS()
        {
            return UAS;
        }

        public int GetWordCount()
        {
            return wordCount;
        }

        public void Add(ParserEvaluationScore parserEvaluationScore)
        {
            LAS = (LAS * wordCount + parserEvaluationScore.LAS * parserEvaluationScore.wordCount) /
                  (wordCount + parserEvaluationScore.wordCount);
            UAS = (UAS * wordCount + parserEvaluationScore.UAS * parserEvaluationScore.wordCount) /
                  (wordCount + parserEvaluationScore.wordCount);
            LS = (LS * wordCount + parserEvaluationScore.LS * parserEvaluationScore.wordCount) /
                 (wordCount + parserEvaluationScore.wordCount);
            wordCount += parserEvaluationScore.wordCount;
        }
    }
}