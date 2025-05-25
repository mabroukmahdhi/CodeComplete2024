// ------------------------------------------
// Copyright (c) 2025 Mabrouk Mahdhi.
// Made with love for Update Conference 2025.
// ------------------------------------------

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
