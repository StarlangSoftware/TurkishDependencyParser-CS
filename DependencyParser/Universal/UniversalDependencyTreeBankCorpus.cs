using System.IO;

namespace DependencyParser.Universal
{
    public class UniversalDependencyTreeBankCorpus : Corpus.Corpus
    {
        private string _language;
        
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