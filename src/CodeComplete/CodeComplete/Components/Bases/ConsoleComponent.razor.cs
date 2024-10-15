// -----------------------------------
// Copyright (c) B&O Service AG.
// Made with love for DevConf 2024.
// -----------------------------------

using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace CodeComplete.Components.Bases
{
    public partial class ConsoleComponent : ComponentBase
    {
        [Parameter]
        public List<string> Logs { get; set; }

        [Parameter]
        public EventCallback<List<string>> LogsChanged { get; set; }

        void OnClearClicked()
        {
            Logs.Clear();
            LogsChanged.InvokeAsync(Logs);
        }
    }
}
