﻿using Microsoft.EntityFrameworkCore;

namespace ProspectaWeb.Models
{
    public class AppDbContext: DbContext

    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
