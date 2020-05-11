using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MaerskLineCMS.Models
{
    public class ITEM
    {
        [Key]
        public int Item_ID { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public int Booking_ID { get; set; }
    }
}
