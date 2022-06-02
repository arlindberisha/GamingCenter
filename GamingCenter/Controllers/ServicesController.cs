using GamingCenter.Data.Services;
using GamingCenter.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GamingCenter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private ServiceServicers _serviceServicers;
        public ServicesController(ServiceServicers serviceServicers)
        {
            _serviceServicers = serviceServicers;
        }
        [HttpPost]
        public IActionResult AddService([FromBody] ServicesVM service)
        {
            _serviceServicers.AddService(service);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetServiceWithClient(int id)
        {
            var response =_serviceServicers.GetServiceWithClients(id);
            return Ok(response);
        }
    }
}
