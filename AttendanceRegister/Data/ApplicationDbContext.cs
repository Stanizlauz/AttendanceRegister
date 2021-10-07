using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceRegister.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Rules> Rules { get; set; }
    }
}
