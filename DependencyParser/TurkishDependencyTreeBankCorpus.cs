using System.Collections.Generic;
using System.Xml;
using Corpus;
using DataStructure;
using Dictionary.Dictionary;

namespace DependencyParser
{
    public class TurkishDependencyTreeBankCorpus : Corpus.Corpus
    {
        /**
         * <summary>Empty constructor for {@link TurkishDependencyTreeBankCorpus}. Initializes the sentences and wordList attributes.</summary>
         */
        public TurkishDependencyTreeBankCorpus()
        {
            sentences = new List<Sentence>();
            wordList = new CounterHashMap<Word>();
        }

        /**
         * <summary>Constructor to create an empty copy of this corpus.</summary>
         * <returns>An empty copy of this corpus.</returns>
         */
        public new TurkishDependencyTreeBankCorpus EmptyCopy()
        {
            return new TurkishDependencyTreeBankCorpus();
        }

        /**
         * <summary>Another constructor for {@link TurkishDependencyTreeBankCorpus}. The method gets the corpus as an xml file, and
         * reads sentences one by one. For each sentence, the function constructs a TurkishDependencyTreeBankSentence.</summary>
         * <param name="fileName">Input file name to read the TurkishDependencyTreeBankCorpus.</param>
         */
        public TurkishDependencyTreeBankCorpus(string fileName)
        {
            var doc = new XmlDocument();
            var assembly = typeof(TurkishDependencyTreeBankCorpus).Assembly;
            var stream = assembly.GetManifestResourceStream("DependencyParser." + fileName);
            doc.Load(stream);
            foreach (XmlNode sentenceNode in doc.ChildNodes[0])
            {
                var sentence = new TurkishDependencyTreeBankSentence(sentenceNode);
                sentences.Add(sentence);
            }
        }
    }
}