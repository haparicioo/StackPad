using System.IO;

using NUnit.Framework;
using Core;

namespace Core.Tests
{
    public class TestTopic
    {
        private Topic topic;

        [SetUp]
        public void Setup()
        {
            topic = new Topic("Topic1");
        }

        [TestCase]
        public void TopicInitialization() {
            Assert.AreEqual("Topic1", topic.Name);
        }

        [TestCase]
        public void SetTopicContent() {
            topic.Content = "Topic1 content";
            Assert.AreEqual("Topic1 content", topic.Content);
        }
    }
}
