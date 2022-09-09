using ApiRestSunat.Domain.DTOs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ApiRestSunat.Controllers
{
    [ApiController]
    [Route("cuentas")]
    public class CuentasController : ControllerBase
    {
        private readonly UserManager<IdentityUser> userManager;

        public CuentasController(UserManager<IdentityUser> userManager)
        {
            this.userManager = userManager;
        }

       

        [HttpPost("registrar")]
        public async Task<ActionResult<RespuestaAuth>> Registrar(CredencialesUsuario credencialesUsuario)
        {
            var usuario = new IdentityUser() { Email }
        }
    }
}
