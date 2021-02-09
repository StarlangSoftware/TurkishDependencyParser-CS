using DependencyParser.Turkish;
using NUnit.Framework;

namespace Test
{
    public class TurkishDependencyRelationTest
    {
        [Test]
        public void TestDependencyType() {
            Assert.True(TurkishDependencyRelation.GetDependencyTag("subject").Equals(TurkishDependencyType.SUBJECT));
            Assert.True(TurkishDependencyRelation.GetDependencyTag("vocative").Equals(TurkishDependencyType.VOCATIVE));
            Assert.True(TurkishDependencyRelation.GetDependencyTag("Relativizer").Equals(TurkishDependencyType.RELATIVIZER));
        }
    }
}