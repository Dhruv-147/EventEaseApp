namespace EventEaseApp.Services
{
    public class UserSession
    {
        public string? UserEmail { get; set; }
        public bool IsRegistered => !string.IsNullOrEmpty(UserEmail);
    }
}
