using ApiAuth.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAuth.Controllers
{
        [ApiController]
    [Route("/V2")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [Route("anonimo")]
        
        public IActionResult AcessoAnonimo()
        {   
            return Ok("Acessou"); ;
        }
        [HttpGet]
        [Route("autenticado")]
        [Authorize]
        public IActionResult usuarioPermitido() {
            return Ok($"Usuario esta autenticado, Nome:{User.Identity.Name}");
        }[HttpGet]
        [Route("manager")]
        [Authorize(Roles = "manager")]
        public IActionResult Chefe() {
            return Ok($"Usuario esta Autorizado");
        }
    }
}
