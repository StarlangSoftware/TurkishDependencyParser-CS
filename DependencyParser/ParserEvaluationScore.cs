namespace DependencyParser
{
    public class ParserEvaluationScore
    {
        private double LAS;
        private double UAS;
        private double LS;
        private int wordCount;

        /// <summary>
        /// Empty constructor of the parser evaluation score object.
        /// </summary>
        public ParserEvaluationScore()
        {
        }

        /// <summary>
        /// Another constructor of the parser evaluation score object.
        /// </summary>
        /// <param name="LAS">Label attachment score</param>
        /// <param name="UAS">Unlabelled attachment score</param>
        /// <param name="LS">Label score</param>
        /// <param name="wordCount">Number of words evaluated</param>
        public ParserEvaluationScore(double LAS, double UAS, double LS, int wordCount)
        {
            this.LAS = LAS;
            this.UAS = UAS;
            this.LS = LS;
            this.wordCount = wordCount;
        }

        /// <summary>
        /// Accessor for the LS field
        /// </summary>
        /// <returns>Label score</returns>
        public double GetLS()
        {
            return LS;
        }

        /// <summary>
        /// Accessor for the LAS field
        /// </summary>
        /// <returns>Label attachment score</returns>
        public double GetLAS()
        {
            return LAS;
        }

        /// <summary>
        /// Accessor for the UAS field
        /// </summary>
        /// <returns>Unlabelled attachment score</returns>
        public double GetUAS()
        {
            return UAS;
        }

        /// <summary>
        /// Accessor for the word count field
        /// </summary>
        /// <returns>Number of words evaluated</returns>
        public int GetWordCount()
        {
            return wordCount;
        }

        /// <summary>
        /// Adds a parser evaluation score to the current evaluation score.
        /// </summary>
        /// <param name="parserEvaluationScore">Parser evaluation score to be added.</param>
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