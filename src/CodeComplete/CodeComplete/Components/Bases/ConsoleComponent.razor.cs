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

        protected override void OnInitialized()
        {
            Logs.Add("System initialized.");
            Logs.Add("User connected.");
            Logs.Add("Data loaded.");
            Logs.Add("Error: Unable to connect to the server.");
        }
    }
}
