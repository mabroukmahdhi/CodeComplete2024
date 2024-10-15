// -----------------------------------
// Copyright (c) B&O Service AG.
// Made with love for DevConf 2024.
// -----------------------------------

namespace CodeComplete.Brokers.Files
{
    public interface IFileBroker
    {
        string ReadFile(string path);
    }
}
