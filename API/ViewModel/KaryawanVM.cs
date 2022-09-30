using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.ViewModel
{
    public class KaryawanVM
    {
        public int Id { get; set; }

        public string Nama { get; set; }

        public string Email { get; set; }

        public int PosisiId { get; set; }

        public int AmbilCuti { get; set; }
    }
}
