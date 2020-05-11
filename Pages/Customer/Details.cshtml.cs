using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MaerskLineCMS.Data;
using MaerskLineCMS.Models;

namespace MaerskLineCMS.Pages.Customer
{
    public class DetailsModel : PageModel
    {
        private readonly MaerskLineCMS.Data.MaerskLineCMSContext _context;

        public DetailsModel(MaerskLineCMS.Data.MaerskLineCMSContext context)
        {
            _context = context;
        }

        public CUSTOMER CUSTOMER { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CUSTOMER = await _context.CUSTOMER.FirstOrDefaultAsync(m => m.Customer_ID == id);

            if (CUSTOMER == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
