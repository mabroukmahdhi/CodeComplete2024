// -----------------------------------
// Copyright (c) B&O Service AG.
// Made with love for DevConf 2024.
// -----------------------------------

using Microsoft.AspNetCore.Components;

namespace CodeComplete.Components.Bases
{
    public partial class PromptComponent : ComponentBase
    {
        [Parameter]
        public string PromptText { get; set; }

        [Parameter]
        public EventCallback<string> PromptTextChanged { get; set; }

        private void SendPrompt() =>
            PromptTextChanged.InvokeAsync(PromptText);
    }
}
