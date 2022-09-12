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
    public class Padron20DataService : IPadron20Service
    {
        private readonly ApiRestDbContext _context;

        public Padron20DataService(ApiRestDbContext context)
        {
            _context = context;
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

        public async Task<PadronSelectDTO> GetPadron20(string ruc)
        {
            //using ApiRestDbContext context = _context;
            var queryable = await (from r in _context.Padron_sunat_20
                             join ct in _context.Ubigeo on r.Ubigeo equals ct.Ubigeo_inei
                             where r.Ruc == ruc
                             select new PadronSelectDTO()
                             {
                                 Ruc = r.Ruc,
                                 RazonSocial = r.RazonSocial,
                                 Estado = r.Estado,
                                 Condicion = r.Condicion,
                                 Ubigeo = r.Ubigeo,
                                 TipoDeVia = r.TipoDeVia,
                                 NombreDeVia = r.NombreDeVia,
                                 CodigoDeZona = r.CodigoDeZona,
                                 TipoDeZona = r.TipoDeZona,
                                 Numero = r.Numero,
                                 Interior = r.Interior,
                                 Lote = r.Lote,
                                 Departamento = r.Departamento,
                                 Manzana = r.Manzana,
                                 Kilometro = r.Kilometro,                             
                                 UDepartamento = ct.Departamento,
                                 UProvincia = ct.Provincia,
                                 UDistrito = ct.Distrito
                             }).AsNoTracking().FirstOrDefaultAsync();

            return queryable;           
        }

        public Task<Padron_sunat_20> Update(int id, Padron_sunat_20 entity)
        {
            throw new NotImplementedException();
        }
    }
}
