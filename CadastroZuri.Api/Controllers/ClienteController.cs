using CadastroZuri.Api.ViewModel;
using CadastroZuri.Business.Contracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace CadastroZuri.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;
        private readonly ILogger<ClienteController> _logger;

        public ClienteController(ILogger<ClienteController> logger,
            IClienteService clienteService
            )
        {
            _logger = logger;
            _clienteService = clienteService;
        }

        [HttpPost()]
        public IActionResult Post([FromBody] ClienteVM cliente)
        {
            if (!ModelState.IsValid)
            {
                return UnprocessableEntity(ModelState);
            }

            var clienteDomain = cliente.MapperToModel();
            _clienteService.InserirCliente(clienteDomain);

            return Ok();
        }
    }
}
