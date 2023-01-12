using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace asp_env_test_pub.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var testUtil = new asp_env_test_pub.Utils.TestUtil();
            var res = testUtil.JoinStr("aaa", "‚ ‚ ‚ ");
            Assert.AreEqual(res, "aaa‚ ‚ ‚ ");
        }

        [TestMethod]
        public void TestMethod2()
        {
            var testUtil = new asp_env_test_pub.Utils.TestUtil();
            var res = testUtil.AddInt(5, -2);
            Assert.AreEqual(res, 3);
        }
    }
}