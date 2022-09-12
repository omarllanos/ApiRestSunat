using ApiRestSunat.Domain.DTOs;
using ApiRestSunat.Domain.Models;
using ApiRestSunat.Domain.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRestSunat.EntityFramework.Services
{
    public class Padron10DataService : IPadron10Service
    {
        private readonly ApiRestDbContext _context;
      
        public Padron10DataService(ApiRestDbContext context)
        {
            _context = context;
          
        }

        public Task<Padron_sunat_10> Create(Padron_sunat_10 entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Padron_sunat_10> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Padron_sunat_10>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<Padron_sunat_10> GetPadron10(string ruc)
        {
            //using ApiRestDbContext context = _contextFactory.CreateDbContext();
            Padron_sunat_10 entity = await _context.Set<Padron_sunat_10>().AsNoTracking().FirstOrDefaultAsync((e) => e.Ruc == ruc);
            return entity;
        }

        public async Task<Padron_sunat_15> GetPadron15(string ruc)
        {
           // using ApiRestDbContext context = _contextFactory.CreateDbContext();
            Padron_sunat_15 entity = await _context.Set<Padron_sunat_15>().AsNoTracking().FirstOrDefaultAsync((e) => e.Ruc == ruc);
            return entity;
        }

        public async Task<Padron_sunat_17> GetPadron17(string ruc)
        {
            //using ApiRestDbContext context = _contextFactory.CreateDbContext();
            Padron_sunat_17 entity = await _context.Set<Padron_sunat_17>().AsNoTracking().FirstOrDefaultAsync((e) => e.Ruc == ruc);
            return entity;
        }

        public async Task<string> GetPadronDni(string Dni)
        {
            //using ApiRestDbContext context = _contextFactory.CreateDbContext();
            var entity = await _context.Set<Padron_sunat_dni>().Where(x => x.Dni.Equals(Dni)).Select(x => new { x.Dni, x.Nombres }).AsNoTracking().FirstOrDefaultAsync();
            if (entity != null)
            {
                return entity.Nombres;
            }
            else
            {
                return "";
            }   
        }

        public Task<Padron_sunat_10> Update(int id, Padron_sunat_10 entity)
        {
            throw new NotImplementedException();
        }
    }
}
