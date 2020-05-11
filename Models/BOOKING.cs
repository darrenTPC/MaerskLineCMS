using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MaerskLineCMS.Models
{
    public class BOOKING
    {
        [Key]
        public int Booking_ID { get; set; }
        public int TEU { get; set; }
        public int Customer_ID { get; set; }
        public int Shipment_ID { get; set; }
        public string Booked_By { get; set; }
        public DateTime Booked_Date { get; set; } = DateTime.Now;
    }
}
