using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLib;

namespace ClassLib.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private readonly Class1 _class1;

        public UnitTest1()
        {
            _class1 = new Class1();
        }

        [TestMethod]
        public void TestMethod1()
        {
            var testVar = 1;
            var result = _class1.Double(testVar);

            Assert.AreEqual(testVar * 2, result);
        }
    }
}
