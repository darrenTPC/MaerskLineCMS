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
    public class IndexModel : PageModel
    {
        private readonly MaerskLineCMS.Data.MaerskLineCMSContext _context;

        public IndexModel(MaerskLineCMS.Data.MaerskLineCMSContext context)
        {
            _context = context;
        }

        public IList<BOOKING> BOOKING { get;set; }

        public async Task OnGetAsync()
        {
            BOOKING = await _context.BOOKING.ToListAsync();
        }
    }
}
