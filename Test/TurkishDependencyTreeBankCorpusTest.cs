using DataStructure;
using DependencyParser;
using NUnit.Framework;

namespace Test
{
    public class TurkishDependencyTreeBankCorpusTest
    {
        [Test]
        public void TestDependencyCorpus()
        {
            var relationCounts = new CounterHashMap<TurkishDependencyType>();
            var corpus = new TurkishDependencyTreeBankCorpus("metu-treebank.xml");
            Assert.AreEqual(5635, corpus.SentenceCount());
            var wordCount = 0;
            for (var i = 0; i < corpus.SentenceCount(); i++)
            {
                var sentence = (TurkishDependencyTreeBankSentence) corpus.GetSentence(i);
                wordCount += sentence.WordCount();
                for (var j = 0; j < sentence.WordCount(); j++)
                {
                    var word = (TurkishDependencyTreeBankWord) sentence.GetWord(j);
                    if (word.GetRelation() != null)
                    {
                        relationCounts.Put(word.GetRelation().GetTurkishDependencyType());
                    }
                }
            }

            Assert.AreEqual(11692, relationCounts[TurkishDependencyType.MODIFIER]);
            Assert.AreEqual(903, relationCounts[TurkishDependencyType.INTENSIFIER]);
            Assert.AreEqual(1142, relationCounts[TurkishDependencyType.LOCATIVE_ADJUNCT]);
            Assert.AreEqual(240, relationCounts[TurkishDependencyType.VOCATIVE]);
            Assert.AreEqual(7261, relationCounts[TurkishDependencyType.SENTENCE]);
            Assert.AreEqual(16, relationCounts[TurkishDependencyType.EQU_ADJUNCT]);
            Assert.AreEqual(159, relationCounts[TurkishDependencyType.NEGATIVE_PARTICLE]);
            Assert.AreEqual(4481, relationCounts[TurkishDependencyType.SUBJECT]);
            Assert.AreEqual(2476, relationCounts[TurkishDependencyType.COORDINATION]);
            Assert.AreEqual(2050, relationCounts[TurkishDependencyType.CLASSIFIER]);
            Assert.AreEqual(73, relationCounts[TurkishDependencyType.COLLOCATION]);
            Assert.AreEqual(1516, relationCounts[TurkishDependencyType.POSSESSOR]);
            Assert.AreEqual(523, relationCounts[TurkishDependencyType.ABLATIVE_ADJUNCT]);
            Assert.AreEqual(23, relationCounts[TurkishDependencyType.FOCUS_PARTICLE]);
            Assert.AreEqual(1952, relationCounts[TurkishDependencyType.DETERMINER]);
            Assert.AreEqual(1361, relationCounts[TurkishDependencyType.DATIVE_ADJUNCT]);
            Assert.AreEqual(202, relationCounts[TurkishDependencyType.APPOSITION]);
            Assert.AreEqual(289, relationCounts[TurkishDependencyType.QUESTION_PARTICLE]);
            Assert.AreEqual(597, relationCounts[TurkishDependencyType.S_MODIFIER]);
            Assert.AreEqual(10, relationCounts[TurkishDependencyType.ETOL]);
            Assert.AreEqual(8338, relationCounts[TurkishDependencyType.OBJECT]);
            Assert.AreEqual(271, relationCounts[TurkishDependencyType.INSTRUMENTAL_ADJUNCT]);
            Assert.AreEqual(85, relationCounts[TurkishDependencyType.RELATIVIZER]);
            Assert.AreEqual(53993, wordCount);
        }
    }
}