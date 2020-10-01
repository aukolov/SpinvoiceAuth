using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Spinvoice.Auth.Pages
{
    public class AuthModel : PageModel
    {
        private readonly ILogger<AuthModel> _logger;

        public AuthModel(ILogger<AuthModel> logger)
        {
            _logger = logger;
        }

        public string AuthKey => $"{Request.Query["code"]}.{Request.Query["realmId"]}";

        public void OnGet()
        {
        }
    }
}