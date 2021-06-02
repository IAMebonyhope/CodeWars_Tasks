using FunctionTasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class DescendingOrderTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int expected = 54421;
            int actual = DescendingOrder.DescendingOrderFunction(42145);
            Assert.AreEqual(expected, actual);
        }
    }
}
