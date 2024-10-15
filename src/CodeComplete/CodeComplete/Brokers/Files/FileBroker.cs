// -----------------------------------
// Copyright (c) B&O Service AG.
// Made with love for DevConf 2024.
// -----------------------------------

namespace CodeComplete.Brokers.Files
{
    public class FileBroker : IFileBroker
    {
        public string ReadFile(string path)
        {
            return System.IO.File.ReadAllText(path);
        }
    }
}
