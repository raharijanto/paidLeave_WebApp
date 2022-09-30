using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace paidLeave_WebApp.Models
{
    public class Gaji
    {
        [Key]
        public int Id { get; set; }
        
        public int GajiAwal { get; set; }

    }
}
