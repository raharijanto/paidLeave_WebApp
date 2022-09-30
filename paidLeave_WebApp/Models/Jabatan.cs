using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace paidLeave_WebApp.Models
{
    public class Jabatan
    {
        [Key]
        public int Id { get; set; }
       
        public string Posisi { get; set; }
        
        public Gaji Gaji { get; set; }
        [ForeignKey("Gaji")]
        public int SalaryId { get; set; }
    }
}
