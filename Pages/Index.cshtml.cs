using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Lab_9_ASP.NET_Core_Navigating_the_Middleware.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger _log;
        public IndexModel(ILogger<IndexModel> log)
        {
            _log = log;
        }
        public void OnGet()
        {
            Object b = null;
            if (b == null) _log.LogWarning("Object is null!");
            else b.ToString();
        }
    }
}
