using System.IO;
using System.Collections.Generic;

using Moq;
using NUnit.Framework;

namespace Core.Tests
{
    public class TestStackPad
    {
        Mock<iStack> stackMock;
        private StackPad pad;

        [SetUp]
        public void Setup()
        {
            pad = new StackPad();

            stackMock = new Mock<iStack>();
            stackMock.Setup(stack => stack.Name).Returns("Main");
            stackMock.Setup(stack => stack.Description).Returns("Main Stack");
        }

        [Test]
        public void TestPathCreation()
        {
            string padParentDir = Path.GetDirectoryName(pad.Path);
            Assert.True(
                Directory.Exists(padParentDir),
                $"{padParentDir} should exist"
            );

            pad.CreateDir();

            Assert.True(
                Directory.Exists(pad.Path),
                $"{pad.Path} should not exist"
            );
        }

        [Test]
        public void TestStackList() {
            pad.AddStack(stackMock.Object);
            Assert.AreEqual(1, pad.Count);

            List<iStack> sList = pad.GetStacks();
            Assert.AreEqual(1, sList.Count);

            Assert.AreEqual("Main", sList[0].Name);
            Assert.AreEqual("Main Stack", sList[0].Description);
        }
    }
}
