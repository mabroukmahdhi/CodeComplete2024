// -----------------------------------
// Copyright (c) B&O Service AG.
// Made with love for DevConf 2024.
// -----------------------------------

using System.Threading.Tasks;

namespace CodeComplete.Brokers.OpenAis
{
    public interface IOpenAiBroker
    {
        ValueTask<string> PostOpenAiPromptAsync(string prompt);
    }
}
