using DependencyParser.Stanford;
using NUnit.Framework;

namespace Test
{
    public class StanfordDependencyRelationTest
    {
        [Test]
        public void TestDependencyType() {
            Assert.True(StanfordDependencyRelation.GetDependencyTag("ACOMP").Equals(StanfordDependencyType.ACOMP));
            Assert.True(StanfordDependencyRelation.GetDependencyTag("DISCOURSE").Equals(StanfordDependencyType.DISCOURSE));
            Assert.True(StanfordDependencyRelation.GetDependencyTag("IOBJ").Equals(StanfordDependencyType.IOBJ));
            Assert.True(StanfordDependencyRelation.GetDependencyTag("iobj").Equals(StanfordDependencyType.IOBJ));
        }
    }
}