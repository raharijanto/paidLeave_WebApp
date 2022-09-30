using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Netto
    {
        [Key]
        public int Id { get; set; }

        public int GajiBersih { get; set; }

        public Gaji Gaji { get; set; }
        [ForeignKey("Gaji")]
        public int GajiId { get; set; }

        public Cuti Cuti { get; set; }
        [ForeignKey("Cuti")]
        public int CutiId { get; set; }
    }
}
