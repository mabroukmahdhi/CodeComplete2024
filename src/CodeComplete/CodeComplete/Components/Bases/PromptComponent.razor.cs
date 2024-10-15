// -----------------------------------
// Copyright (c) B&O Service AG.
// Made with love for DevConf 2024.
// -----------------------------------

using System;
using Microsoft.AspNetCore.Components;

namespace CodeComplete.Components.Bases
{
    public partial class PromptComponent : ComponentBase
    {
        [Parameter]
        public string PromptText { get; set; }

        [Parameter]
        public EventCallback<string> PromptTextChanged { get; set; }

        [Parameter]
        public Action<string> CompleteClicked { get; set; }

        private void OnCompleteClicked() =>
            CompleteClicked?.Invoke(PromptText);
    }
}
