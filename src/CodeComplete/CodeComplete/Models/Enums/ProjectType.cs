﻿// -----------------------------------
// Copyright (c) B&O Service AG.
// Made with love for DevConf 2024.
// -----------------------------------

namespace CodeComplete.Models.Enums
{
    public enum ProjectType : int
    {
        Api = 0,
        BlazorWasm = 1,
        BlazorServer = 2,
        Maui = 3,
        Microservice = 4,
        Component = 5,
        CodeFile = 6,
        Unknown = 100
    }
}