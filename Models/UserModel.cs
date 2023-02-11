namespace ASP.NETWEBAPI.Models
{
    public class UserModel
    {
        public required string Username { get; set; }
        public  string Password { get; set; }
        public required string EmailAddress { get; set; }
        public required string Role { get; set; }
        public required string Surname { get; set; }
        public required string GivenName { get; set; }
    }
}
