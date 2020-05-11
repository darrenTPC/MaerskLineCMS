using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MaerskLineCMS.Data;
using MaerskLineCMS.Models;

namespace MaerskLineCMS.Pages.Shipment
{
    public class DeleteModel : PageModel
    {
        private readonly MaerskLineCMS.Data.MaerskLineCMSContext _context;

        public DeleteModel(MaerskLineCMS.Data.MaerskLineCMSContext context)
        {
            _context = context;
        }

        [BindProperty]
        public SHIPMENT SHIPMENT { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SHIPMENT = await _context.SHIPMENT.FirstOrDefaultAsync(m => m.Shipment_ID == id);

            if (SHIPMENT == null)
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

            SHIPMENT = await _context.SHIPMENT.FindAsync(id);

            if (SHIPMENT != null)
            {
                _context.SHIPMENT.Remove(SHIPMENT);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
