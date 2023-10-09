namespace HPCProjectTemplate.Server.Models
{
    public class CreditCard
    {
        public int Id { get; set; }
        public string name_on_card { get; set; }
        public long number { get; set; }
        public string zip_code { get; set; }
        public string ccv { get; set; }
        public DateTime expiration_date { get; set; }
    }
}
