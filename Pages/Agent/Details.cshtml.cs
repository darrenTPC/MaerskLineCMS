using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MaerskLineCMS.Data;
using MaerskLineCMS.Models;

namespace MaerskLineCMS.Pages.Agent
{
    public class DetailsModel : PageModel
    {
        private readonly MaerskLineCMS.Data.MaerskLineCMSContext _context;

        public DetailsModel(MaerskLineCMS.Data.MaerskLineCMSContext context)
        {
            _context = context;
        }

        public AGENT AGENT { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AGENT = await _context.AGENT.FirstOrDefaultAsync(m => m.Agent_ID == id);

            if (AGENT == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
