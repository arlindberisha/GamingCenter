using System.Collections.Generic;

namespace GamingCenter.Data.Models
{
    public class Clients
    {
        public int Id { get; set; }
        public string Name { get; set; }

         public List<Client_Services> Client_Services { get; set; }
    }
}
