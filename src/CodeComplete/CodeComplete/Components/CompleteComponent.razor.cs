// ------------------------------------------
// Copyright (c) 2025 Mabrouk Mahdhi.
// Made with love for Update Conference 2025.
// ------------------------------------------

using System;
using System.Collections.Generic;
using System.Text.Json;
using CodeComplete.Models;
using CodeComplete.Services;
using Microsoft.AspNetCore.Components;

namespace CodeComplete.Components
{
    public partial class CompleteComponent : ComponentBase
    {
        [Inject]
        protected ICompleteService CompleteService { get; set; }

        private List<string> logs = [];
        private CompleteSettings settings = null;

        async void OnCompleteClicked(string prompt)
        {
            var response = await CompleteService.PostCompletionAsync(prompt);

            string formattedResponse = response.Replace("```json", "").Trim('`').Trim();
            logs.Add(formattedResponse);

            try
            {
                settings = JsonSerializer.Deserialize<CompleteSettings>(formattedResponse);
            }
            catch (Exception ex)
            {
                logs.Add(ex.Message);
            }


            StateHasChanged();
        }
    }
}
