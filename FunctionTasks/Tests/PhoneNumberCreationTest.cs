using FunctionTasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class PhoneNumberCreationTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string expected = "(123) 456-7890";
            string actual = PhoneNumberCreation.CreatePhoneNumber(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 });
            Assert.AreEqual(expected, actual);
        }
    }
}
