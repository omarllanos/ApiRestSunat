using ApiRestSunat.Domain.DTOs;
using ApiRestSunat.Domain.Models;
using ApiRestSunat.Domain.Services;
using ApiRestSunat.EntityFramework.Common;

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
        private readonly ApiRestDbContextFactory _contextFactory;
        private readonly NoQueryDataService<Padron_sunat_10> _nonQueryDataService;
        public Padron10DataService(ApiRestDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
            _nonQueryDataService = new NoQueryDataService<Padron_sunat_10>(contextFactory);
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
            using ApiRestDbContext context = _contextFactory.CreateDbContext();
            Padron_sunat_10 entity = await context.Set<Padron_sunat_10>().FirstOrDefaultAsync((e) => e.Ruc == ruc);
            return entity;
        }

        public async Task<string> GetPadronDni(string Dni)
        {
            using ApiRestDbContext context = _contextFactory.CreateDbContext();
            var entity = await context.Set<Padron_sunat_10>().Select(x => new { x.Ruc, x.RazonSocial }).FirstOrDefaultAsync((e) => e.Ruc.Contains(Dni));
            var value = entity.RazonSocial;
            return value;
        }

        public Task<Padron_sunat_10> Update(int id, Padron_sunat_10 entity)
        {
            throw new NotImplementedException();
        }
    }
}
