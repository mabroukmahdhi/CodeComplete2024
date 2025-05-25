// ------------------------------------------
// Copyright (c) 2025 Mabrouk Mahdhi.
// Made with love for Update Conference 2025.
// ------------------------------------------

using CodeComplete.Models;
using Microsoft.AspNetCore.Components;

namespace CodeComplete.Components.Bases
{
    public partial class SettingsComponent : ComponentBase
    {
        [Parameter]
        public CompleteSettings Settings { get; set; }

        [Parameter]
        public EventCallback<CompleteSettings> SettingsChanged { get; set; }
    }
}
