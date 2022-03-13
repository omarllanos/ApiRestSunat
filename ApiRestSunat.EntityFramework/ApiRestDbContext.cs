
using ApiRestSunat.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRestSunat.EntityFramework
{
    public class ApiRestDbContext : DbContext
    {
        public ApiRestDbContext(DbContextOptions options):base(options) 
        {
        }
        public virtual DbSet<Padron_sunat_10> Padron_sunat_10 { get; set; }
        public virtual DbSet<Padron_sunat_20> Padron_sunat_20 { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        
    }
}
