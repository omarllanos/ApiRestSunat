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
    public class Padron20DataService : IPadron20Service
    {
        private readonly ApiRestDbContextFactory _contextFactory;

        public Padron20DataService(ApiRestDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public Task<Padron_sunat_20> Create(Padron_sunat_20 entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Padron_sunat_20> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Padron_sunat_20>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<Padron_sunat_20> GetPadron20(string ruc)
        {
            using ApiRestDbContext context = _contextFactory.CreateDbContext();
            Padron_sunat_20 entity = await context.Set<Padron_sunat_20>().FirstOrDefaultAsync((e) => e.Ruc == ruc);
            return entity;
        }

        public Task<Padron_sunat_20> Update(int id, Padron_sunat_20 entity)
        {
            throw new NotImplementedException();
        }
    }
}
