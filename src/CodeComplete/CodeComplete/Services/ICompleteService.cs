// -----------------------------------
// Copyright (c) B&O Service AG.
// Made with love for DevConf 2024.
// -----------------------------------

using System.Threading.Tasks;

namespace CodeComplete.Services
{
    public interface ICompleteService
    {
        ValueTask<string> PostCompletionAsync(string prompt);
    }
}
