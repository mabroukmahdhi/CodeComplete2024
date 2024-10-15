// -----------------------------------
// Copyright (c) B&O Service AG.
// Made with love for DevConf 2024.
// -----------------------------------

using System.Collections.Generic;
using CodeComplete.Models.Enums;

namespace CodeComplete.Models
{
    public class CompleteSettings
    {
        public ProjectType ProjectType { get; set; }
        public string ProjectName { get; set; }
        public List<string> Models { get; set; }
        public bool AddStorageBroker { get; set; }
        public bool AddFoundationService { get; set; }
    }
}
