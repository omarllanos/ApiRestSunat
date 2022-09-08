
using ApiRestSunat.Domain.DTOs;
using ApiRestSunat.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestSunat.Domain.Services
{
    public interface IPadron10Service : IDataService<Padron_sunat_10>
    {
        Task<Padron_sunat_10> GetPadron10(string ruc);
        Task<Padron_sunat_15> GetPadron15(string ruc);
        Task<Padron_sunat_17> GetPadron17(string ruc);
        Task<string> GetPadronDni(string Dni);
    }
}
