using GamingCenter.Data.Models;
using GamingCenter.Data.ViewModels;
using System.Linq;

namespace GamingCenter.Data.Services
{
    public class ClientsServices
    {
        private AppDbContext _context;
        public ClientsServices(AppDbContext context)
        {
            _context = context;
        }
        public void AddClient(ClientsVM client)
        {
            var _client = new Clients()
            {
                Name = client.Name,              
            };
            _context.Clients.Add(_client);
            _context.SaveChanges();
            foreach (var id in client.serviceIds)
            {
                var _client_service = new Client_Services()
                {
                    ClientId = _client.Id,
                    ServicesId = id
                };
                _context.Client_Services.Add(_client_service);
                _context.SaveChanges();
            }
        }
        public ClientWithServicesVM GetClientWithServices(int clientId)
        {
            var _client = _context.Clients.Where(n => n.Id == clientId).Select(n => new ClientWithServicesVM ()
            {
                Name = n.Name,
                ClientServices = n.Client_Services.Select(n => n.Service.Name).ToList()
            }).FirstOrDefault();
            return _client;
            //To Do
            //Edit ClientController
        }
    }
}
