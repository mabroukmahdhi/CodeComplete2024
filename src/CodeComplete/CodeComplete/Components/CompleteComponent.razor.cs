// -----------------------------------
// Copyright (c) B&O Service AG.
// Made with love for DevConf 2024.
// -----------------------------------

using System.Collections.Generic;
using CodeComplete.Services;
using Microsoft.AspNetCore.Components;

namespace CodeComplete.Components
{
    public partial class CompleteComponent : ComponentBase
    {
        [Inject]
        protected ICompleteService CompleteService { get; set; }

        private string promptText;
        private List<string> logs = [];

        async void OnCompleteClicked(string prompt)
        {
            var response = await CompleteService.PostCompletionAsync(prompt);
            logs.Add(response);

            StateHasChanged();
        }
    }
}
