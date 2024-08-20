using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using trainning_code.Models;

namespace trainning_code.Data
{
    public class trainning_codeContext : DbContext
    {
        public trainning_codeContext (DbContextOptions<trainning_codeContext> options)
            : base(options)
        {
        }

        public DbSet<trainning_code.Models.Movie> Movie { get; set; } = default!;
    }
}
