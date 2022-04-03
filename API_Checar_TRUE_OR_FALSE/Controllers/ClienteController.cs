using API_Checar_TRUE_OR_FALSE.Entidade;
using API_Checar_TRUE_OR_FALSE.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace API_Checar_TRUE_OR_FALSE.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IMapper _mapper;
        public ClienteController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult ChecarLiberarCliente(Cliente cliente)
        {

            var autorizado = _mapper.Map<ClienteViewModel>(cliente);
            return Ok(autorizado);
          
        }

    }
}
