using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MvcNetCoreChollometro.Models;

namespace MvcNetCoreChollometro.Data
{
    public class ChollometroContext: DbContext
    {
        public ChollometroContext(DbContextOptions<ChollometroContext>
            options) : base(options) { }
        public DbSet<Chollo> Chollos { get; set; }
    }
}
