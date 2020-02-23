using NUnit.Framework;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            var valuesController = new ValuesController();
            var returnValue = valuesController.Get(5);
            Assert.AreEqual(5, returnValue);
        }
    }
}