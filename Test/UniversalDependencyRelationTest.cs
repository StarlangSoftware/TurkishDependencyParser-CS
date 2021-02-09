using DependencyParser.Universal;
using NUnit.Framework;

namespace Test
{
    public class UniversalDependencyRelationTest
    {
        [Test]
        public void TestDependencyPosType() {
            Assert.True(UniversalDependencyRelation.GetDependencyPosType("adj").Equals(UniversalDependencyPosType.ADJ));
            Assert.True(UniversalDependencyRelation.GetDependencyPosType("intj").Equals(UniversalDependencyPosType.INTJ));
            Assert.True(UniversalDependencyRelation.GetDependencyPosType("Det").Equals(UniversalDependencyPosType.DET));
        }
        
        [Test]
        public void TestDependencyType() {
            Assert.True(UniversalDependencyRelation.GetDependencyTag("acl").Equals(UniversalDependencyType.ACL));
            Assert.True(UniversalDependencyRelation.GetDependencyTag("iobj").Equals(UniversalDependencyType.IOBJ));
            Assert.True(UniversalDependencyRelation.GetDependencyTag("Iobj").Equals(UniversalDependencyType.IOBJ));
            Assert.True(UniversalDependencyRelation.GetDependencyTag("fixed").Equals(UniversalDependencyType.FIXED));
        }

    }
}