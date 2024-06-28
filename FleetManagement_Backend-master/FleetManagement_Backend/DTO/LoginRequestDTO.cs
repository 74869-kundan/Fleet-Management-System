namespace FleetManagement_Backend.DTO
{
    public class LoginRequestDTO
    {
        public string? email { get; set; }
        public string? password { get; set; }

        public override string? ToString()
        {
            return "LoginRequestDTO [email=" + email + ", password=" + password + "]";
        }
    }
}
