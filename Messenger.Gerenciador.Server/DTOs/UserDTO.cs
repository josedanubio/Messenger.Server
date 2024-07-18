namespace Messenger.Gerenciador.Server.DTOs
{
    public class UserDTO
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty;
        public string Area { get; set; } = string.Empty;
        public string Manager { get; set; } = string.Empty;
        public string RegistrationNumber { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Profile { get; set; }
    }
}

public class AuthRequest
{
    public string RegistrationNumber { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}
