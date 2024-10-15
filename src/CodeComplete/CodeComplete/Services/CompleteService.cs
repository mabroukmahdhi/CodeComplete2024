// -----------------------------------
// Copyright (c) B&O Service AG.
// Made with love for DevConf 2024.
// -----------------------------------

using System;
using System.Threading.Tasks;
using CodeComplete.Brokers.Files;
using CodeComplete.Brokers.OpenAis;

namespace CodeComplete.Services
{
    public class CompleteService(IOpenAiBroker openAiBroker, IFileBroker fileBroker) : ICompleteService
    {
        private readonly IOpenAiBroker openAiBroker = openAiBroker;
        private readonly IFileBroker fileBroker = fileBroker;

        public async ValueTask<string> PostCompletionAsync(string prompt)
        {
            if (string.IsNullOrWhiteSpace(prompt))
                return string.Empty;

            var settings = this.fileBroker.ReadFile("./Templates/completesettings.json");

            var promptText = "You are a software engineer and got this requirement to implement something (Api, Blazor app, maui app, or simply a component... anything in .NET) " +
                $"{Environment.NewLine}'{prompt}'{Environment.NewLine}" +
                $"Please answer only in this format and ONLY THE JSON CONTENT: {Environment.NewLine}{settings}";

            return await this.openAiBroker.PostOpenAiPromptAsync(promptText);
        }
    }
}
