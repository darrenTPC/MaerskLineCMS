using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MaerskLineCMS.Pages
{
    public class AdminHomeModel : PageModel
    {
        private readonly ILogger<AdminHomeModel> _logger;

        public AdminHomeModel(ILogger<AdminHomeModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {

        }
    }
}