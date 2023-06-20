using CadastroZuri.Business.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CadastroZuri.Repository.Data
{
    public class ZuriDbContext : DbContext
    {
        public ZuriDbContext(DbContextOptions<ZuriDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Cliente>().HasKey(c => c.Id);


            base.OnModelCreating(builder);
        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
