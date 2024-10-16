using NUnit.Framework;

namespace com.fjvieira.aipoweredcoding.explain
{
    public class BTest
    {
        [Test]
        public void TestSolution()
        {
            Assert.Multiple(() =>
            {
                Assert.That(B.Solution(new int[] { }), Is.EqualTo(-1));
                Assert.That(B.Solution(new int[] { 11 }), Is.EqualTo(0));
                Assert.That(B.Solution(new int[] { 1, 0 }), Is.EqualTo(-1));
                Assert.That(B.Solution(new int[] { 1, 1, 1 }), Is.EqualTo(1));
                Assert.That(B.Solution(new int[] { 0, 0, 0, 1, 1, 1 }), Is.EqualTo(-1));
                Assert.That(B.Solution(new int[] { 3, 4, 3, 2, 3, -1, 3, 3 }), Is.EqualTo(7));
                Assert.That(B.Solution(new int[] { 0, 0, 0, 0, 1, 1, 1, 1, 1 }), Is.EqualTo(8));
                Assert.That(B.Solution(new int[] { 0, 0, 0, 0, 1, 1, 1, 1 }), Is.EqualTo(-1));
                Assert.That(B.Solution(new int[] { 0, 0, 0, 0, 2, 1, 1, 1, 1 }), Is.EqualTo(-1));
            });
        }
    }
}