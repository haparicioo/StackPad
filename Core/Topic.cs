using System;

namespace Core
{
    public interface iTopic {
        public string Name {get;}
        public string Content {get; set;}
    }
    public class Topic: iTopic
    {
        private string name;
        private string content;

        public string Name => name;
        public string Content {
            get => content;
            set => content = value;
        }


        public Topic(string name) {
            this.name = name;
        }
    }
}
