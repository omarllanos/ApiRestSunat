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
        private readonly NoQueryDataService<padron_sunat_10> _nonQueryDataService;
        public Padron10DataService(ApiRestDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
            _nonQueryDataService = new NoQueryDataService<padron_sunat_10>(contextFactory);
        }

        public Task<padron_sunat_10> Create(padron_sunat_10 entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<padron_sunat_10> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<padron_sunat_10>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<padron_sunat_10> GetPadron10(string ruc)
        {
            using ApiRestDbContext context = _contextFactory.CreateDbContext();
            padron_sunat_10 entity = await context.Set<padron_sunat_10>().FirstOrDefaultAsync((e) => e.Ruc == ruc);
            return entity;
        }

        public Task<padron_sunat_10> Update(int id, padron_sunat_10 entity)
        {
            throw new NotImplementedException();
        }
    }
}
