using System.Xml;
using Corpus;

namespace DependencyParser.Turkish
{
    public class TurkishDependencyTreeBankSentence : Sentence
    {
        /**
         * <summary>Given the parsed xml node which contains information about a sentence, the method constructs a
         * {@link TurkishDependencyTreeBankSentence} from it.</summary>
         * <param name="sentenceNode">Xml parsed node containing information about a sentence.</param>
         */
        public TurkishDependencyTreeBankSentence(XmlNode sentenceNode)
        {
            foreach (XmlNode wordNode in sentenceNode.ChildNodes)
            {
                var word = new TurkishDependencyTreeBankWord(wordNode);
                words.Add(word);
            }
        }

        /**
         * <summary>Calculates the maximum of all word to related word distances, where the distances are calculated in terms of
         * index differences.</summary>
         * <returns>Maximum of all word to related word distances.</returns>
         */
        public int MaxDependencyLength()
        {
            var max = 0;
            for (var i = 0; i < words.Count; i++)
            {
                var word = (TurkishDependencyTreeBankWord) words[i];
                if (word.GetRelation() != null && word.GetRelation().To() - i > max)
                {
                    max = word.GetRelation().To() - i;
                }
            }

            return max;
        }
    }
}