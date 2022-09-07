
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
        public virtual DbSet<Padron_sunat_15> Padron_sunat_15 { get; set; }
        public virtual DbSet<Padron_sunat_17> Padron_sunat_17 { get; set; }
        public virtual DbSet<Padron_sunat_dni> Padron_sunat_dni { get; set; }
        public virtual DbSet<Ubigeo> Ubigeo { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        
    }
}
