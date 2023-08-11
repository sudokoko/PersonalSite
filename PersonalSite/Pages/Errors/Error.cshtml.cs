using Microsoft.AspNetCore.Mvc;
using Sudokoko.PersonalSite.Pages.Layouts;

namespace Sudokoko.PersonalSite.Pages.Errors;

public class Error : PageLayout
{
    public int ErrorCode { get; set; }

    public IActionResult OnGet([FromRoute] int code)
    {
        this.ErrorCode = code;

        return this.Page();
    }
}