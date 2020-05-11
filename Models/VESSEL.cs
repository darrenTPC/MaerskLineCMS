using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MaerskLineCMS.Models
{
    public class VESSEL
    {
        [Key]
        public int Vessel_ID { get; set; }
        public string Vessel_Name { get; set; }
        public int Capacity_TEU { get; set; }
        public int Available_TEU { get; set; }
        public string Status { get; set; }
    }
}
