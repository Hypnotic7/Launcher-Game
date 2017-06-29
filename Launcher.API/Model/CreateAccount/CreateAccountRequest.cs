namespace Launcher.API.Model.CreateAccount
{
    public class CreateAccountRequest
    {
        public string Email { get; set; }
        public string AccountName { get; set; }
        public string AccountPassword { get; set; }
        public string AccountRetypePassword { get; set; }        
    }
}
