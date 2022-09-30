using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Cuti
    {
        [Key]
        public int Id { get; set; }

        public int JumlahCuti { get; set; }
    }
}
