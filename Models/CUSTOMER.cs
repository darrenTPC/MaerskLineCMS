using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MaerskLineCMS.Models
{
    public class CUSTOMER
    {
        [Key]
        public int Customer_ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
    }
}
