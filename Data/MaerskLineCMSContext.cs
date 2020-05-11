using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MaerskLineCMS.Models;

namespace MaerskLineCMS.Data
{
    public class MaerskLineCMSContext : DbContext
    {
        public MaerskLineCMSContext (DbContextOptions<MaerskLineCMSContext> options)
            : base(options)
        {
        }

        public DbSet<MaerskLineCMS.Models.VESSEL> VESSEL { get; set; }

        public DbSet<MaerskLineCMS.Models.SHIPMENT> SHIPMENT { get; set; }

        public DbSet<MaerskLineCMS.Models.AGENT> AGENT { get; set; }

        public DbSet<MaerskLineCMS.Models.CUSTOMER> CUSTOMER { get; set; }

        public DbSet<MaerskLineCMS.Models.BOOKING> BOOKING { get; set; }

        public DbSet<MaerskLineCMS.Models.ITEM> ITEM { get; set; }
    }
}
