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

        public PadronSunatController(IPadron10Service padron10Service)
        {
            _padron10Service = padron10Service;
        }
        //[HttpGet("{id}")]
        //public string Get(string ruc)
        //{
        //    return "hola";
        //}
        //public Task<ActionResult<string>> Get(string id)
        //{
        //    //return Ok;
        //    //var recuperar = await _padron10Service.GetPadron10(id);
        //    //return recuperar.Ruc;
        //}
    }
}
