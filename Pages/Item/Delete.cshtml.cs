using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MaerskLineCMS.Data;
using MaerskLineCMS.Models;

namespace MaerskLineCMS.Pages.Item
{
    public class DeleteModel : PageModel
    {
        private readonly MaerskLineCMS.Data.MaerskLineCMSContext _context;

        public DeleteModel(MaerskLineCMS.Data.MaerskLineCMSContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ITEM ITEM { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ITEM = await _context.ITEM.FirstOrDefaultAsync(m => m.Item_ID == id);

            if (ITEM == null)
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

            ITEM = await _context.ITEM.FindAsync(id);

            if (ITEM != null)
            {
                _context.ITEM.Remove(ITEM);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
