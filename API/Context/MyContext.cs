using API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> dbContext) : base(dbContext)
        {

        }

        public DbSet<Cuti> Cuti { get; set; }

        public DbSet<Karyawan> Karyawan { get; set; }

        public DbSet<Jabatan> Jabatan { get; set; }

        public DbSet<Gaji> Gaji { get; set; }

        public DbSet<Netto> Netto { get; set; }

        public DbSet<Pengguna> Pengguna { get; set; }
    }
}
