// ------------------------------------------
// Copyright (c) 2025 Mabrouk Mahdhi.
// Made with love for Update Conference 2025.
// ------------------------------------------

using System.Threading.Tasks;

namespace CodeComplete.Services
{
    public interface ICompleteService
    {
        ValueTask<string> PostCompletionAsync(string prompt);
    }
}
