using System;

namespace Core
{
    public interface iStack {
        public string Name {get;}
        public string Description {get;}
        public DateTime Created {get;}
    }
    public class Stack: iStack
    {
        private string name;
        private string description;
        private DateTime created;

        public string Name => name;

        public string Description  => description;
        public DateTime Created => created;


        public Stack(string name, string description) {
            this.name = name;
            this.description = description;
            this.created = DateTime.Now;
        }
    }
}
