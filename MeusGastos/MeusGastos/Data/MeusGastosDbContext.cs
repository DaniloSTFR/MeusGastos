using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MeusGastos.Data
{
    public class MeusGastosDbContext : IdentityDbContext
    {
        //public MeusGastosDbContext(DbContextOptions<MeusGastosDbContext> options)
        //    : base(options)
        //{
        //}

        private readonly DbContextOptions _options;

        public MeusGastosDbContext(DbContextOptions options) : base(options)
        {
            _options = options;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
