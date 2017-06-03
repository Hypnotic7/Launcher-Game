namespace Launcher.API.Model.CreateAccount
{
    public class CreateAccountRequest
    {
        public string AccountName { get; set; }
        public string AccountPassword { get; set; }
        public string Email { get; set; }
    }
}
