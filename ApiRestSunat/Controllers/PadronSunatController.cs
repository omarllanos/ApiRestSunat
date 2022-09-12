using ApiRestSunat.Domain.DTOs;
using ApiRestSunat.Domain.Models;
using ApiRestSunat.Domain.Services;
using ApiRestSunat.Domain.Services.PadronRuc;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestSunat.Controllers
{
    [ApiController]
    [Route("[controller]")]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "EsAdmin")]
    public class PadronSunatController : ControllerBase
    {
       
        private readonly IPadronLogicaService _padronlogicaService;
        public PadronSunatController(IPadronLogicaService padronlogicaService)
        {
            _padronlogicaService = padronlogicaService;
        }
        [HttpGet("empresa/{ruc}")]
        //[AllowAnonymous]
        public async Task<ActionResult<PadronSunatDTO>> GetPadronSunat(string ruc)
        {
           
            var padron = await _padronlogicaService.GetPadronRuc(ruc);
            if (padron != null)
            {
                return padron;
            }
            else
            {
                return NotFound();
            }
        }
        [HttpGet("persona/{dni}")]      
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "EsAdmin")]
        public async Task<ActionResult<PadronSunatDniDTO>> GetPadronDni(string dni)
        {
            //var emailClaim = HttpContext.User.Claims.Where(claim => claim.Type == "email").FirstOrDefault(); //solo funca si hay autorize
            var padron = await _padronlogicaService.GetPadronDni(dni);
            if (padron != null)
            {
                return padron;
            }
            else
            {
                return NotFound();
            }
            //if (padron.Equals(""))
            //{
            //   return NotFound();
            //}
            //else
            //{ 
            //   return padron; 
            //}
        }
    }
}
