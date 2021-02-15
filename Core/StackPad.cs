using System;
using System.IO;
using System.Collections.Generic;

namespace Core
{
    public class StackPad
    {
	    private string path;
        private const string name = "StackPad";
        private List<iStack> stackList;

        public string Path => path;
        public int Count => stackList.Count;

        public StackPad() {
            var userDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            path = System.IO.Path.Combine(userDir, name);
            stackList = new List<iStack>();
        }

        public void CreateDir() {
            Directory.CreateDirectory(path);
        }

        public void AddStack(iStack stack) {
            stackList.Add(stack);
        }

        public List<iStack> GetStacks() {
            return stackList;
        }
    }
}
