namespace dotnet_mvc_first_app.Models
{
    public class ProfileViewModel
    {
        public string Username { get; set; }   // login name
        public string FullName { get; set; }   // nama lengkap user
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Role { get; set; }       // misalnya Admin/User
    }
}
