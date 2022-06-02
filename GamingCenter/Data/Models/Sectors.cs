using System.Collections.Generic;

namespace GamingCenter.Data.Models
{
    public class Sectors
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Workers> Workers { get; set; }
        public List<Service> Service { get; set; }
    }
}
