using System.Collections.Generic;

namespace GamingCenter.Data.ViewModels
{
    public class SectorsVM
    {
        public string Name { get; set; }
    }
    public class ClientServiceVM
    {
        public string ServiceName { get; set; }
        public List<string> ClientsName { get; set; }
    }
    public class SectorWithClientServiceVM
    {
        public string Name { get; set; }
        public List<ClientServiceVM> ClientServices { get; set; }
        public List<string> Workers { get; set; }
    }
}
