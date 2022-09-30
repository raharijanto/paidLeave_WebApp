using Microsoft.EntityFrameworkCore;
using paidLeave_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paidLeave_WebApp.Context
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
    }
}
