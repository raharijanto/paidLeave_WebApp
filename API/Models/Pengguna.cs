using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Pengguna
    {
        public Karyawan Karyawan { get; set; }
        [Key]
        [ForeignKey("Karyawan")]
        public int Id { get; set; }

        public string Password { get; set; }
    }
}
