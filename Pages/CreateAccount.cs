using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lotre.Pages;

public class CreateAccount : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public CreateAccount(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
