﻿using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Sudokoko.PersonalSite.Entities;
using Sudokoko.PersonalSite.Pages.Layouts;

namespace Sudokoko.PersonalSite.Pages;

public class Home : PageLayout
{
    public Lanyard? Lanyard { get; set; }
    public LanyardActivity? LanyardActivity { get; set; }

    public async Task<IActionResult> OnGet()
    {
        HttpClient httpClient = new()
        {
            BaseAddress = new Uri("https://api.lanyard.rest/v1/users/"),
            DefaultRequestHeaders =
            {
                {
                    "User-Agent", "sudokoko.xyz ASP.NET/5.0 HttpClient"
                },
            },
        };

        string reqString = await httpClient.GetStringAsync("988640695847890955");

        Lanyard? lanyard = JsonSerializer.Deserialize<Lanyard>(reqString);

        this.Lanyard = lanyard;
        this.LanyardActivity = lanyard?.Data.Activities.FirstOrDefault(a => a.Type == LanyardActivity.LanyardActivityType.RichPresence);

        return this.Page();
    }
}