using AulaAPI.DataModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AulaAPI.Controllers
{
    [Authorize]
    [Route("api/token")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly IJWTAuthenticationManager jwt;

        public TokenController( IJWTAuthenticationManager jwt)
        {
            this.jwt = jwt;
        }

        [HttpGet]
        [Route("endpoint1")]
        public IActionResult getEP1()
        {
            Usuario user = new Usuario();
            user.login = "teste";
            user.senha = "2222";
            return Ok(user);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("endpoint2")]
        public string getEP2()
        {
            return "end point 2";
        }

        [AllowAnonymous]
        [HttpPost("autenticar")]
        public IActionResult Autenticar([FromBody] Usuario usuario)
        {
            var token = jwt.Authenticate(usuario.login, usuario.senha);

            if(token == null)
                return Unauthorized();

            return Ok(token);
        }
    }
}
