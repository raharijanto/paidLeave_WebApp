using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Karyawan
    {
        [Key]
        public int Id { get; set; }

        public string Nama { get; set; }

        public string Email { get; set; }

        public Jabatan Jabatan { get; set; }
        [ForeignKey("Jabatan")]
        public int PosisiId { get; set; }

        public Cuti Cuti { get; set; }
        [ForeignKey("Cuti")]
        public int AmbilCuti { get; set; }
    }
}
