using GamingCenter.Data.Services;
using GamingCenter.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GamingCenter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private ClientsServices _clientServices;
        public ClientsController(ClientsServices clientsServices)
        {
            _clientServices = clientsServices;
        }
        [HttpPost]
        public IActionResult AddClient([FromBody] ClientsVM client)
        {
            _clientServices.AddClient(client);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetClientServicesById(int id)
        {
            var response =_clientServices.GetClientWithServices(id);
            return Ok(response);
        }
    }
}
