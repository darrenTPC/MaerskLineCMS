using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MaerskLineCMS.Data;
using MaerskLineCMS.Models;

namespace MaerskLineCMS.Pages.Booking
{
    public class EditModel : PageModel
    {
        private readonly MaerskLineCMS.Data.MaerskLineCMSContext _context;

        public EditModel(MaerskLineCMS.Data.MaerskLineCMSContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(BOOKING).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BOOKINGExists(BOOKING.Booking_ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool BOOKINGExists(int id)
        {
            return _context.BOOKING.Any(e => e.Booking_ID == id);
        }
    }
}
