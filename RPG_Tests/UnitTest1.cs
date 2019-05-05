using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPG_WorkShop;

namespace RPG_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var target = new Novice();
            var result = target.Name;
            const string accept = "Novice";
            Assert.AreEqual(accept, result);
        }
    }
}