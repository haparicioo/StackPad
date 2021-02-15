using System.IO;

using NUnit.Framework;
using Core;

namespace Core.Tests
{
    public class TestStack
    {
        private Stack pad;

        [SetUp]
        public void Setup()
        {
            pad = new Stack("Main", "Main stack for principal stuff");
        }

        [TestCase]
        public void StackInitialization() {
            Assert.AreEqual("Main", pad.Name);
            Assert.AreEqual("Main stack for principal stuff", pad.Description);
        }
    }
}
