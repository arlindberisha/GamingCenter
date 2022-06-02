using GamingCenter.Data.Services;
using GamingCenter.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GamingCenter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SectorsController : ControllerBase
    {
        private SectorServicers _sectorsServices;
        public SectorsController(SectorServicers sectorsServices)
        {
            _sectorsServices = sectorsServices;
        }
        [HttpPost]
        public IActionResult AddSector([FromBody] SectorsVM sector)
        {
            _sectorsServices.AddSector(sector);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetSectorWithClientService(int id)
        {
            var response = _sectorsServices.GetSectorWithServiceData(id);
            return Ok(response);
        }
    }
}
