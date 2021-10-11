using ApiRestSunat.Models;
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
        public virtual DbSet<padron_sunat_10> padron_sunat_10 { get; set; }
        public virtual DbSet<padron_sunat_20> padron_sunat_20 { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        
    }
}
