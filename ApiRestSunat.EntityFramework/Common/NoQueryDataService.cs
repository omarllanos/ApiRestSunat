using ApiRestSunat.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRestSunat.EntityFramework.Common
{
    public class NoQueryDataService<T> where T : DomainObject
    {

        private readonly ApiRestDbContextFactory _contextfactory;

        public NoQueryDataService(ApiRestDbContextFactory contextfactory)
        {
            _contextfactory = contextfactory;
        }
        public async Task<T> Create(T entity)
        {

            using ApiRestDbContext context = _contextfactory.CreateDbContext();
            EntityEntry<T> CrearResultado = await context.Set<T>().AddAsync(entity);
            // context.Add(entity);
            await context.SaveChangesAsync();
            return CrearResultado.Entity;

        }

        public async Task<bool> Delete(int id)
        {
            using (ApiRestDbContext context = _contextfactory.CreateDbContext())
            {
                T entity = await context.Set<T>().FirstOrDefaultAsync((e) => e.Id == id);
                context.Set<T>().Remove(entity);
                await context.SaveChangesAsync();
                return true;
            }
        }
        public async Task<T> Update(int id, T entity)
        {
            using (ApiRestDbContext context = _contextfactory.CreateDbContext())
            {
                entity.Id = id;
                context.Set<T>().Update(entity);
                await context.SaveChangesAsync();
                return entity;
            }
        }

    }
}
