// -----------------------------------
// Copyright (c) B&O Service AG.
// Made with love for DevConf 2024.
// -----------------------------------

using System.Threading.Tasks;
using CodeComplete.Brokers.OpenAis;

namespace CodeComplete.Services
{
    public class CompleteService(IOpenAiBroker openAiBroker) : ICompleteService
    {
        private readonly IOpenAiBroker openAiBroker = openAiBroker;

        public async ValueTask<string> PostCompletionAsync(string prompt) =>
            await this.openAiBroker.PostOpenAiPromptAsync(prompt);
    }
}
