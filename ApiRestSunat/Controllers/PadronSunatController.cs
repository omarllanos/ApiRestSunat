using ApiRestSunat.Domain.Models;
using ApiRestSunat.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestSunat.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PadronSunatController : ControllerBase
    {
        private readonly IPadron10Service _padron10Service;
        private readonly IPadron20Service _padron20Service;
        public PadronSunatController(IPadron10Service padron10Service, IPadron20Service padron20Service)
        {
            _padron10Service = padron10Service;
            _padron20Service = padron20Service;
        }
        [HttpGet("{ruc}")]    
        public async Task<ActionResult<PadronSunat>> GetPadronSunat(string ruc)
        {
            var Padron = new PadronSunat();

            var sunat10 = await _padron10Service.GetPadron10(ruc);
            if (sunat10 == null)
            {
                var sunat20 = await _padron20Service.GetPadron20(ruc);
                if (sunat20 == null)
                {
                    return NotFound();
                }
                else
                {
                    Padron = sunat20;
                    return Ok(Padron);
                }
            }
            else
            {
                Padron = sunat10;
                return Ok(Padron);
            }

        }
    }
}
