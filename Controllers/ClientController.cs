using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using listClient.Services;

namespace listClient.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly ClientService _clientService;

        public ClientController(ClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet]
        [EnableCors("AllowOrigin")]
        public IActionResult Getclients(int skip = -1, int take = -1)
        {
            var clients = _clientService.GetClientList(skip, take);
            return Ok(clients);
        }
        [HttpGet("autocomplete")]
        [EnableCors("AllowOrigin")]
        public IActionResult Getclientautocomplete()
        {
            var clients = _clientService.GetClientListToAutoComplete();
            return Ok(clients);
        }
        [HttpGet("search")]
        [EnableCors("AllowOrigin")]
        public IActionResult Searchclients([FromQuery] string searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm))
            {
                searchTerm = string.Empty;
            }
            var clients = _clientService.SearchClients(searchTerm);
            return Ok(clients);
        }
    }
    
}
