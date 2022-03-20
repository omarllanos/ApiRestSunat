using ApiRestSunat.Domain.DTOs;
using ApiRestSunat.Domain.Models;
using ApiRestSunat.Domain.Services;
using ApiRestSunat.Domain.Services.PadronRuc;
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
       
        private readonly IPadronLogicaService _padronlogicaService;
        public PadronSunatController(IPadronLogicaService padronlogicaService)
        {
            _padronlogicaService = padronlogicaService;
        }
        [HttpGet("{ruc}")]    
        public async Task<ActionResult<PadronSunatDTO>> GetPadronSunat(string ruc)
        {
            var padron = await _padronlogicaService.GetPadronRuc(ruc);
            if (padron != null)
            {
                return Ok(padron);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
