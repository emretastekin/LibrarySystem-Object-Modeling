using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SoftITO.Project.Models;

namespace SoftITO.Project.Data
{
    public class SoftITOProjectContext : DbContext
    {
        public SoftITOProjectContext (DbContextOptions<SoftITOProjectContext> options)
            : base(options)
        {
        }

        public DbSet<SoftITO.Project.Models.Book> Book { get; set; } = default!;
        public DbSet<SoftITO.Project.Models.Author> Author { get; set; } = default!;
    }
}
