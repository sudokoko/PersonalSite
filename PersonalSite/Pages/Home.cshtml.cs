using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Sudokoko.PersonalSite.Pages;

public class Home : PageModel
{
    public IActionResult OnGet() => this.Page();
}