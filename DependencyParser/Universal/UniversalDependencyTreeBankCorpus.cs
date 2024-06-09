using System.IO;

namespace DependencyParser.Universal
{
    public class UniversalDependencyTreeBankCorpus : Corpus.Corpus
    {
        private string _language;

        /// <summary>
        /// Empty constructor.
        /// </summary>
        public UniversalDependencyTreeBankCorpus()
        {
        }

        /// <summary>
        /// Constructs a universal dependency corpus from an input file. Reads the sentences one by one and constructs a
        /// universal dependency sentence from each line read.
        /// </summary>
        /// <param name="fileName">Input file name.</param>
        public UniversalDependencyTreeBankCorpus(string fileName)
        {
            var assembly = typeof(UniversalDependencyTreeBankCorpus).Assembly;
            _language = fileName.Substring(0, fileName.IndexOf('_'));
            var stream = assembly.GetManifestResourceStream("DependencyParser." + fileName);
            var streamReader = new StreamReader(stream);
            var line = streamReader.ReadLine();
            var sentence = "";
            while (line != null)
            {
                if (line.Length == 0)
                {
                    AddSentence(new UniversalDependencyTreeBankSentence(_language, sentence));
                    sentence = "";
                }
                else
                {
                    sentence += line + "\n";
                }
                line = streamReader.ReadLine();
            }
        }

        /// <summary>
        /// Compares the corpus with the given corpus and returns a parser evaluation score for this comparison. The result
        /// is calculated by summing up the parser evaluation scores of sentence by sentence comparisons.
        /// </summary>
        /// <param name="corpus">Universal dependency corpus to be compared.</param>
        /// <returns>A parser evaluation score object.</returns>
        public ParserEvaluationScore CompareParses(UniversalDependencyTreeBankCorpus corpus)
        {
            var score = new ParserEvaluationScore();
            for (var i = 0; i < sentences.Count; i++)
            {
                score.Add(((UniversalDependencyTreeBankSentence)sentences[i]).CompareParses(
                    (UniversalDependencyTreeBankSentence)corpus.GetSentence(i)));
            }

            return score;
        }
    }
}