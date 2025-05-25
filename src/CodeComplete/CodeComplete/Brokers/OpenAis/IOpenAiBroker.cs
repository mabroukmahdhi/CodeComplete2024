// ------------------------------------------
// Copyright (c) 2025 Mabrouk Mahdhi.
// Made with love for Update Conference 2025.
// ------------------------------------------

using System.Threading.Tasks;

namespace CodeComplete.Brokers.OpenAis
{
    public interface IOpenAiBroker
    {
        ValueTask<string> PostOpenAiPromptAsync(string prompt);
    }
}
