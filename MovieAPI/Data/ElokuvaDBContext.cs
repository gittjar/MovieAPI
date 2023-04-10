using System;
using Microsoft.EntityFrameworkCore;

namespace MovieAPI.Data
{
    public class ElokuvaDBContext : DbContext
    {
        public ElokuvaDBContext(DbContextOptions<ElokuvaDBContext> options)
            : base(options)
        {
        }

        public DbSet<MovieAPI.Models.Movie> Movie { get; set; } = default!;
    }
}

