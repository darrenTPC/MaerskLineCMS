using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MaerskLineCMS.Models
{
    public class SHIPMENT
    {
        [Key]
        public int Shipment_ID { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime Departure_Date { get; set; }
        public DateTime Arrival_Date { get; set; }
        public int Vessel_ID { get; set; }
    }
}
