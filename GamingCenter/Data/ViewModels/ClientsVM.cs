using System.Collections.Generic;

namespace GamingCenter.Data.ViewModels
{
    public class ClientsVM
    {
        public string Name { get; set; }
        public List<int> serviceIds { get; set; }
    }
    public class ClientWithServicesVM
    {
        public string Name { get; set; }
        public List<string> ClientServices { get; set; }
    }
}
