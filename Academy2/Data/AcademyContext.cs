using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Academy2.Models;

namespace Academy2.Data
{
    public class AcademyContext : DbContext
    {
        public AcademyContext(DbContextOptions<AcademyContext> options)
            : base(options)
        {
        }

        public DbSet<Academy2.Models.Direction> Directions { get; set; } = default!;
        public DbSet<Academy2.Models.Group> Groups { get; set; } = default!;
        public DbSet<Academy2.Models.Student> Students { get; set; } = default!;
        public DbSet<Academy2.Models.Teacher> Teachers { get; set; } = default!;
    }
}
