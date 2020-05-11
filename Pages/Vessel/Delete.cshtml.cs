using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MaerskLineCMS.Data;
using MaerskLineCMS.Models;

namespace MaerskLineCMS.Pages.Vessel
{
    public class DeleteModel : PageModel
    {
        private readonly MaerskLineCMS.Data.MaerskLineCMSContext _context;

        public DeleteModel(MaerskLineCMS.Data.MaerskLineCMSContext context)
        {
            _context = context;
        }

        [BindProperty]
        public VESSEL VESSEL { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            VESSEL = await _context.VESSEL.FirstOrDefaultAsync(m => m.Vessel_ID == id);

            if (VESSEL == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            VESSEL = await _context.VESSEL.FindAsync(id);

            if (VESSEL != null)
            {
                _context.VESSEL.Remove(VESSEL);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
