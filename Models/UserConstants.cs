namespace ASP.NETWEBAPI.Models
{
    public class UserConstants
    {
        public static List<UserModel> Users = new List<UserModel>()
        {
            new UserModel() { Username = "test1_admin", EmailAddress = "test1.admin@email.com", Password = "admin", GivenName = "Macro", Surname = "Code", Role = "Administrator" },
            new UserModel() { Username = "test2_admin", EmailAddress = "test2.admin@email.com", Password = "admin", GivenName = "Obadiah", Surname = "Korir", Role = "Seller" },
        };
    }
}
