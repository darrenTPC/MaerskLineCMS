using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MaerskLineCMS.Data;
using MaerskLineCMS.Models;

namespace MaerskLineCMS.Pages.Booking
{
    public class DeleteModel : PageModel
    {
        private readonly MaerskLineCMS.Data.MaerskLineCMSContext _context;

        public DeleteModel(MaerskLineCMS.Data.MaerskLineCMSContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BOOKING BOOKING { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BOOKING = await _context.BOOKING.FirstOrDefaultAsync(m => m.Booking_ID == id);

            if (BOOKING == null)
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

            BOOKING = await _context.BOOKING.FindAsync(id);

            if (BOOKING != null)
            {
                _context.BOOKING.Remove(BOOKING);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
