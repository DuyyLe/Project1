using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectAlta.Entity;

namespace ProjectAlta.Data
{
    public class ProjectAltaContext : DbContext
    {
        public ProjectAltaContext (DbContextOptions<ProjectAltaContext> options)
            : base(options)
        {
        }

        public DbSet<ProjectAlta.Entity.Grade>? Grade { get; set; }

        public DbSet<ProjectAlta.Entity.Admin>? Admin { get; set; }
    }
}
