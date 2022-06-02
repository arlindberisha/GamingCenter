namespace GamingCenter.Data.ViewModels
{
    public class WorkersVM
    {
        public string Name { get; set; }
        public bool Gender { get; set; }

        public int SectorId { get; set; }   
    }
    public class WorkersWithSectorsVM
    {
        public string Name { get; set; }
        public bool Gender { get; set; }

        public string SectorName { get; set; }
    }
}
