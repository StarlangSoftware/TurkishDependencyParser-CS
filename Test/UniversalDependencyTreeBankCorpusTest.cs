using DependencyParser.Universal;
using NUnit.Framework;

namespace Test
{
    public class UniversalDependencyTreeBankCorpusTest
    {
        private int WordCount(UniversalDependencyTreeBankCorpus corpus)
        {
            var wordCount = 0;
            for (var i = 0; i < corpus.SentenceCount(); i++)
            {
                wordCount += corpus.GetSentence(i).WordCount();
            }

            return wordCount;
        }

        [Test]
        public void TestDependencyCorpus1()
        {
            var corpus = new UniversalDependencyTreeBankCorpus("tr_gb-ud-test.conllu");
            Assert.AreEqual(2802, corpus.SentenceCount());
            Assert.AreEqual(16881, WordCount(corpus));
        }

        [Test]
        public void TestDependencyCorpus2()
        {
            var corpus = new UniversalDependencyTreeBankCorpus("tr_imst-ud-dev.conllu");
            Assert.AreEqual(988, corpus.SentenceCount());
            Assert.AreEqual(10046, WordCount(corpus));
        }

        [Test]
        public void TestDependencyCorpus3()
        {
            var corpus = new UniversalDependencyTreeBankCorpus("tr_imst-ud-test.conllu");
            Assert.AreEqual(983, corpus.SentenceCount());
            Assert.AreEqual(10029, WordCount(corpus));
        }

        [Test]
        public void TestDependencyCorpus4()
        {
            var corpus = new UniversalDependencyTreeBankCorpus("tr_imst-ud-train.conllu");
            Assert.AreEqual(3664, corpus.SentenceCount());
            Assert.AreEqual(37784, WordCount(corpus));
        }

        [Test]
        public void TestDependencyCorpus5()
        {
            var corpus = new UniversalDependencyTreeBankCorpus("tr_pud-ud-test.conllu");
            Assert.AreEqual(1000, corpus.SentenceCount());
            Assert.AreEqual(16882, WordCount(corpus));
        }

        [Test]
        public void TestDependencyCorpus6()
        {
            var corpus = new UniversalDependencyTreeBankCorpus("tr_boun-ud-dev.conllu");
            Assert.AreEqual(979, corpus.SentenceCount());
            Assert.AreEqual(12074, WordCount(corpus));
        }

        [Test]
        public void TestDependencyCorpus7()
        {
            var corpus = new UniversalDependencyTreeBankCorpus("tr_boun-ud-test.conllu");
            Assert.AreEqual(979, corpus.SentenceCount());
            Assert.AreEqual(12095, WordCount(corpus));
        }

        [Test]
        public void TestDependencyCorpus8()
        {
            var corpus = new UniversalDependencyTreeBankCorpus("tr_boun-ud-train.conllu");
            Assert.AreEqual(7803, corpus.SentenceCount());
            Assert.AreEqual(98214, WordCount(corpus));
        }

        [Test]
        public void TestDependencyCorpus9()
        {
            var corpus = new UniversalDependencyTreeBankCorpus("en_atis-ud-dev.conllu");
            Assert.AreEqual(572, corpus.SentenceCount());
            Assert.AreEqual(6644, WordCount(corpus));
        }

        [Test]
        public void TestDependencyCorpus10()
        {
            var corpus = new UniversalDependencyTreeBankCorpus("en_atis-ud-test.conllu");
            Assert.AreEqual(586, corpus.SentenceCount());
            Assert.AreEqual(6580, WordCount(corpus));
        }

        [Test]
        public void TestDependencyCorpus11()
        {
            var corpus = new UniversalDependencyTreeBankCorpus("en_atis-ud-train.conllu");
            Assert.AreEqual(4274, corpus.SentenceCount());
            Assert.AreEqual(48655, WordCount(corpus));
        }

        [Test]
        public void TestDependencyCorpus12()
        {
            var corpus = new UniversalDependencyTreeBankCorpus("tr_atis-ud-dev.conllu");
            Assert.AreEqual(572, corpus.SentenceCount());
            Assert.AreEqual(4862, WordCount(corpus));
        }

        [Test]
        public void TestDependencyCorpus13()
        {
            var corpus = new UniversalDependencyTreeBankCorpus("tr_atis-ud-test.conllu");
            Assert.AreEqual(586, corpus.SentenceCount());
            Assert.AreEqual(4813, WordCount(corpus));
        }

        [Test]
        public void TestDependencyCorpus14()
        {
            var corpus = new UniversalDependencyTreeBankCorpus("tr_atis-ud-train.conllu");
            Assert.AreEqual(4274, corpus.SentenceCount());
            Assert.AreEqual(36200, WordCount(corpus));
        }

        [Test]
        public void TestDependencyCorpus15()
        {
            var corpus =
                new UniversalDependencyTreeBankCorpus("tr_framenet-ud-dev.conllu");
            Assert.AreEqual(205, corpus.SentenceCount());
            Assert.AreEqual(1421, WordCount(corpus));
        }

        [Test]
        public void TestDependencyCorpus16()
        {
            var corpus =
                new UniversalDependencyTreeBankCorpus("tr_framenet-ud-test.conllu");
            Assert.AreEqual(205, corpus.SentenceCount());
            Assert.AreEqual(1467, WordCount(corpus));
        }

        [Test]
        public void TestDependencyCorpus17()
        {
            var corpus =
                new UniversalDependencyTreeBankCorpus("tr_framenet-ud-train.conllu");
            Assert.AreEqual(2288, corpus.SentenceCount());
            Assert.AreEqual(16333, WordCount(corpus));
        }

        [Test]
        public void TestDependencyCorpus18()
        {
            var corpus = new UniversalDependencyTreeBankCorpus("tr_kenet-ud-dev.conllu");
            Assert.AreEqual(1646, corpus.SentenceCount());
            Assert.AreEqual(17554, WordCount(corpus));
        }

        [Test]
        public void TestDependencyCorpus19()
        {
            var corpus = new UniversalDependencyTreeBankCorpus("tr_kenet-ud-test.conllu");
            Assert.AreEqual(1643, corpus.SentenceCount());
            Assert.AreEqual(17817, WordCount(corpus));
        }

        [Test]
        public void TestDependencyCorpus20()
        {
            UniversalDependencyTreeBankCorpus
                corpus = new UniversalDependencyTreeBankCorpus("tr_kenet-ud-train.conllu");
            Assert.AreEqual(15398, corpus.SentenceCount());
            Assert.AreEqual(143287, WordCount(corpus));
        }

        [Test]
        public void TestDependencyCorpus21()
        {
            var corpus = new UniversalDependencyTreeBankCorpus("tr_penn-ud-dev.conllu");
            Assert.AreEqual(622, corpus.SentenceCount());
            Assert.AreEqual(6994, WordCount(corpus));
        }

        [Test]
        public void TestDependencyCorpus22()
        {
            var corpus = new UniversalDependencyTreeBankCorpus("tr_penn-ud-test.conllu");
            Assert.AreEqual(924, corpus.SentenceCount());
            Assert.AreEqual(10047, WordCount(corpus));
        }

        [Test]
        public void TestDependencyCorpus23()
        {
            var corpus = new UniversalDependencyTreeBankCorpus("tr_penn-ud-train.conllu");
            Assert.AreEqual(14850, corpus.SentenceCount());
            Assert.AreEqual(166513, WordCount(corpus));
        }

        [Test]
        public void TestDependencyCorpus24()
        {
            UniversalDependencyTreeBankCorpus
                corpus = new UniversalDependencyTreeBankCorpus("tr_tourism-ud-dev.conllu");
            Assert.AreEqual(2166, corpus.SentenceCount());
            Assert.AreEqual(10203, WordCount(corpus));
        }

        [Test]
        public void TestDependencyCorpus25()
        {
            var corpus =
                new UniversalDependencyTreeBankCorpus("tr_tourism-ud-test.conllu");
            Assert.AreEqual(2191, corpus.SentenceCount());
            Assert.AreEqual(10125, WordCount(corpus));
        }

        [Test]
        public void TestDependencyCorpus26()
        {
            var corpus =
                new UniversalDependencyTreeBankCorpus("tr_tourism-ud-train.conllu");
            Assert.AreEqual(15476, corpus.SentenceCount());
            Assert.AreEqual(71141, WordCount(corpus));
        }
    }
}