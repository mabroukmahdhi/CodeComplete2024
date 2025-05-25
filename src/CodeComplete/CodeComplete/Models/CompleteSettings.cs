// ------------------------------------------
// Copyright (c) 2025 Mabrouk Mahdhi.
// Made with love for Update Conference 2025.
// ------------------------------------------

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
