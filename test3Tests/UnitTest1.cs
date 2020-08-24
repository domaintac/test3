using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test3Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1Equal1()
        {
            Assert.IsTrue(1 == 1);
        }

        [TestMethod]
        public void Test1Equal2()
        {
            Assert.IsTrue(1 == 2);
        }
    }
}
