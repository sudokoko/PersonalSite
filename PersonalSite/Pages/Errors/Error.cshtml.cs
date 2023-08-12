using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Sudokoko.PersonalSite.Pages.Layouts;

namespace Sudokoko.PersonalSite.Pages.Errors;

public class Error : PageLayout
{
    public int ErrorCode { get; set; }
    public string? ErrorMessage { get; set; }

    public IActionResult OnGet([FromRoute] int code)
    {
        this.ErrorCode = code;

        IExceptionHandlerPathFeature? exceptionHandler = this.HttpContext.Features.Get<IExceptionHandlerPathFeature>();
        if (exceptionHandler == null) return this.Page();
        
        this.ErrorMessage = exceptionHandler.Error.Message;

        return this.Page();
    }
}