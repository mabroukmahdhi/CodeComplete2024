// -----------------------------------
// Copyright (c) B&O Service AG.
// Made with love for DevConf 2024.
// -----------------------------------

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
