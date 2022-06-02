using System.Collections.Generic;

namespace GamingCenter.Data.ViewModels
{
    public class ServicesVM
    {
        public string Name { get; set; }

        public int SectorId { get; set; }
    }
    public class ServiceWithClientsVM
    {
        public string Name { get; set; }
        public List<string> ClientsName { get; set; }
    }
}
