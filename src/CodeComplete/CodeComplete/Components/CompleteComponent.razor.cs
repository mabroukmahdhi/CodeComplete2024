// -----------------------------------
// Copyright (c) B&O Service AG.
// Made with love for DevConf 2024.
// -----------------------------------

using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace CodeComplete.Components
{
    public partial class CompleteComponent : ComponentBase
    {
        private string promptText;
        private List<string> logs = new();
    }
}
