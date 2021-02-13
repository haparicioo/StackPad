using System;
using System.IO;

namespace Core
{
    public class StackPad
    {
	    private string path;
        private const string name = "StackPad";

        public string Path {
            get {return path;}
        }

        public StackPad() {
            var userDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            path = System.IO.Path.Combine(userDir, name);
        }

        public void CreateDir() {
            Directory.CreateDirectory(path);
        }
    }
}
