using DependencyParser.Universal;
using NUnit.Framework;

namespace Test
{
    public class UniversalDependencyTreeBankCorpusTest
    {
        private int WordCount(UniversalDependencyTreeBankCorpus corpus){
            var wordCount = 0;
            for (var i = 0; i < corpus.SentenceCount(); i++){
                wordCount += corpus.GetSentence(i).WordCount();
            }
            return wordCount;
        }

        [Test]
        public void TestDependencyCorpus1() {
            var corpus = new UniversalDependencyTreeBankCorpus("tr_gb-ud-test.conllu");
            Assert.AreEqual(2802, corpus.SentenceCount());
            Assert.AreEqual(16881, WordCount(corpus));
        }

        [Test]
        public void TestDependencyCorpus2() {
            var corpus = new UniversalDependencyTreeBankCorpus("tr_imst-ud-dev.conllu");
            Assert.AreEqual(988, corpus.SentenceCount());
            Assert.AreEqual(10046, WordCount(corpus));
        }

        [Test]
        public void TestDependencyCorpus3() {
            var corpus = new UniversalDependencyTreeBankCorpus("tr_imst-ud-test.conllu");
            Assert.AreEqual(983, corpus.SentenceCount());
            Assert.AreEqual(10029, WordCount(corpus));
        }

        [Test]
        public void TestDependencyCorpus4() {
            var corpus = new UniversalDependencyTreeBankCorpus("tr_imst-ud-train.conllu");
            Assert.AreEqual(3664, corpus.SentenceCount());
            Assert.AreEqual(37784, WordCount(corpus));
        }

        [Test]
        public void TestDependencyCorpus5() {
            var corpus = new UniversalDependencyTreeBankCorpus("tr_pud-ud-test.conllu");
            Assert.AreEqual(1000, corpus.SentenceCount());
            Assert.AreEqual(16882, WordCount(corpus));
        }

    }
}