using GamingCenter.Data.Models;
using GamingCenter.Data.ViewModels;
using System.Linq;

namespace GamingCenter.Data.Services
{
    public class ServiceServicers
    {
        private AppDbContext _context;
        public ServiceServicers(AppDbContext context)
        {
            _context = context;
        }

        public void AddService(ServicesVM service)
        {
            var _service = new Service()
            {
                Name = service.Name,
                SectorsId=service.SectorId
                
            };
            _context.Services.Add(_service);
            _context.SaveChanges();
        }
        public ServiceWithClientsVM GetServiceWithClients(int serviceId)
        {
            var _service = _context.Services.Where(n=>n.Id == serviceId).Select(n=> new ServiceWithClientsVM()
            {
                Name=n.Name,
                ClientsName=n.Client_Services.Select(n=>n.Clients.Name).ToList()
            }).FirstOrDefault();
            return _service;
        }
    }
}
