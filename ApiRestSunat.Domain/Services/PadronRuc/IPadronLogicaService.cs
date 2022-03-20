using ApiRestSunat.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRestSunat.Domain.Services.PadronRuc
{
    public interface IPadronLogicaService
    {
        Task<PadronSunatDTO> GetPadronRuc(string ruc);
    }
}
