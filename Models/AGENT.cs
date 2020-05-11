using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MaerskLineCMS.Models
{
    public class AGENT
    {
        [Key]
        public int Agent_ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string SignIn_ID { get; set; }
        public string Password { get; set; }
    }
}
