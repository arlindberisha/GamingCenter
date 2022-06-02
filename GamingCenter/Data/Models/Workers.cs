using System;

namespace GamingCenter.Data.Models
{
    public class Workers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Gender { get; set; }
        public DateTime DateStarted { get; set; }


        public int SectorsId { get; set; }
        public Sectors Sectors { get; set; }
    }
}
