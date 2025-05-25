// ------------------------------------------
// Copyright (c) 2025 Mabrouk Mahdhi.
// Made with love for Update Conference 2025.
// ------------------------------------------

using System;
using Microsoft.AspNetCore.Components;

namespace CodeComplete.Components.Bases
{
    public partial class PromptComponent : ComponentBase
    {
        [Parameter]
        public string PromptText { get; set; } = "I want to create a new blazor app with the name 'MyBlazorApp'.";

        [Parameter]
        public EventCallback<string> PromptTextChanged { get; set; }

        [Parameter]
        public Action<string> CompleteClicked { get; set; }

        private void OnCompleteClicked() =>
            CompleteClicked?.Invoke(PromptText);
    }
}
