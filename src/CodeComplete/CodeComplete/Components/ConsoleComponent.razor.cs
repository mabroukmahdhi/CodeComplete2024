// -----------------------------------
// Copyright (c) B&O Service AG.
// Made with love for DevConf 2024.
// -----------------------------------

using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace CodeComplete.Components
{
    public partial class ConsoleComponent : ComponentBase
    {
        private List<string> logs = new();

        protected override void OnInitialized()
        {
            logs.Add("System initialized.");
            logs.Add("User connected.");
            logs.Add("Data loaded.");
            logs.Add("Error: Unable to connect to the server.");
        }
    }
}
