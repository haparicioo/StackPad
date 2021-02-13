using System.IO;

using NUnit.Framework;
using Core;

namespace Core.Tests
{
    public class TestStackPad
    {
        private StackPad pad;

        [SetUp]
        public void Setup()
        {
            pad = new StackPad();
        }

        [Test]
        public void TestPath()
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
    }
}
