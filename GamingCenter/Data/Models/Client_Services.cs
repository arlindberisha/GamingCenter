namespace GamingCenter.Data.Models
{
    public class Client_Services
    {
        public int Id { get; set; }


        public int ClientId { get; set; }
        public Clients Clients { get; set; }

        public int ServicesId { get; set; }
        public Service Service { get; set; }
    }
}
