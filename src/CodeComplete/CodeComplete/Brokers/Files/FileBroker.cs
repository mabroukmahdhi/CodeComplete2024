// ------------------------------------------
// Copyright (c) 2025 Mabrouk Mahdhi.
// Made with love for Update Conference 2025.
// ------------------------------------------

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
