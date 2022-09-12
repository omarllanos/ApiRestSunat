
using ApiRestSunat.Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRestSunat.EntityFramework
{
    public class ApiRestDbContext : IdentityDbContext
    {
        public ApiRestDbContext(DbContextOptions<ApiRestDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {    
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Padron_sunat_10> Padron_sunat_10 { get; set; }
        public virtual DbSet<Padron_sunat_20> Padron_sunat_20 { get; set; }
        public virtual DbSet<Padron_sunat_15> Padron_sunat_15 { get; set; }
        public virtual DbSet<Padron_sunat_17> Padron_sunat_17 { get; set; }
        public virtual DbSet<Padron_sunat_dni> Padron_sunat_dni { get; set; }
        public virtual DbSet<Ubigeo> Ubigeo { get; set; }
       
        
    }
}
