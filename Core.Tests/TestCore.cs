using NUnit.Framework;
using Core;

namespace Core.Tests
{
    public class TestCore
    {
        private Core _core;

        [SetUp]
        public void Setup()
	{
            _core = new Core();
        }

        [Test]
        public void Test1()
        {
            Assert.IsTrue(_core.TestWorking(), "Should be true");
            Assert.Pass();
        }
    }
}
