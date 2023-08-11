using Microsoft.AspNetCore.Mvc;
using Sudokoko.PersonalSite.Pages.Layouts;

namespace Sudokoko.PersonalSite.Pages;

public class Home : PageLayout
{
    public IActionResult OnGet() => this.Page();
}