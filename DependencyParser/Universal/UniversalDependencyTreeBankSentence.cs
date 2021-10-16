using System.Collections.Generic;
using Corpus;

namespace DependencyParser.Universal
{
    public class UniversalDependencyTreeBankSentence : Sentence
    {
        private List<string> comments;

        public UniversalDependencyTreeBankSentence()
        {
            comments = new List<string>();
        }

        public void AddComment(string comment)
        {
            comments.Add(comment);
        }

        public override string ToString()
        {
            var result = "";
            foreach (var comment in comments)
            {
                result += comment + "\n";
            }

            foreach (var w in words)
            {
                var word = (UniversalDependencyTreeBankWord)w;
                result += word + "\n";
            }

            return result;
        }

        public ParserEvaluationScore CompareParses(UniversalDependencyTreeBankSentence sentence)
        {
            var score = new ParserEvaluationScore();
            for (var i = 0; i < words.Count; i++)
            {
                var relation1 = ((UniversalDependencyTreeBankWord)words[i]).GetRelation();
                var relation2 = ((UniversalDependencyTreeBankWord)sentence.GetWord(i)).GetRelation();
                if (relation1 != null && relation2 != null)
                {
                    score.Add(relation1.CompareRelations(relation2));
                }
            }

            return score;
        }
    }
}