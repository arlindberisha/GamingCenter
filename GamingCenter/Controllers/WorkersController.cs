using GamingCenter.Data.Services;
using GamingCenter.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GamingCenter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkersController : ControllerBase
    {
        public WorkersServices _workersServices;
        public WorkersController(WorkersServices workersServices)
        {
            _workersServices=workersServices;
        }
        [HttpPost]
        public IActionResult AddWorker([FromBody]WorkersVM worker)
        {
            _workersServices.AddWorkers(worker);
            return Ok();
        }
        [HttpGet]
        public IActionResult GetWorkers()
        {
            var allWorkers= _workersServices.GetAllWorkers();
            return Ok(allWorkers);
        }
        [HttpGet("{id}")]
        public IActionResult GetWorkerById(int id)
        {
            var worker = _workersServices.GetWorkerById(id);
            return Ok(worker);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateWorkerById(int id, [FromBody]WorkersVM worker)
        {
            var updatedWorker=_workersServices.UpdateWorkerById(id, worker);
            return Ok(updatedWorker);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteWorkerById(int id)
        {
            _workersServices.DeleteWorkerById(id);
            return Ok();
        }
    }
}
