using GamingCenter.Data.Models;
using GamingCenter.Data.ViewModels;
using System.Linq;

namespace GamingCenter.Data.Services
{
    public class SectorServicers
    {
        private AppDbContext _context;
        public SectorServicers(AppDbContext context)
        {
            _context = context;
        }

        public void AddSector(SectorsVM sector)
        {
            var _sector = new Sectors()
            {
                Name = sector.Name,

            };
            _context.Sectors.Add(_sector);
            _context.SaveChanges();
        }
        public SectorWithClientServiceVM GetSectorWithServiceData(int sectorId)
        {
            var _sectorData = _context.Sectors.Where(n => n.Id == sectorId).Select(n => new SectorWithClientServiceVM()
            {
                Name = n.Name,
                ClientServices = n.Service.Select(n => new ClientServiceVM()
                {
                    ServiceName = n.Name,
                    ClientsName = n.Client_Services.Select(n => n.Clients.Name).ToList(),
                }).ToList(),
                Workers = n.Workers.Select(n=>n.Name).ToList(),
            }).FirstOrDefault();
            return _sectorData;
        }
    }
}
