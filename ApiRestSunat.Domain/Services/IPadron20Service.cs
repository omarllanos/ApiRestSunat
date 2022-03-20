using ApiRestSunat.Domain.DTOs;
using ApiRestSunat.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRestSunat.Domain.Services
{
    public interface IPadron20Service : IDataService<Padron_sunat_20>
    {
        Task<PadronSelectDTO> GetPadron20(string ruc);
    }
}
