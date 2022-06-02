using System.Collections.Generic;

namespace GamingCenter.Data.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int SectorsId { get; set; }
        public Sectors Sectors { get; set; }
        public List<Client_Services> Client_Services { get; set; }

    }
}
