namespace HPCProjectTemplate.Server.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public enum AccountType
        {
            Basic = 0,
            Pro = 1
        }

        public CreditCard CreditCard { get; set; } = new();
    }
}
