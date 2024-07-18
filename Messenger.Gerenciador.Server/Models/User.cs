namespace Messenger.Gerenciador.Server.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public int Status_Id { get; set; }
        public DateTime? Ultimo_Login_Data { get; set; }
        public DateTime? Ultima_Alteracao_Senha_Data { get; set; }
        public bool Aceitou_Termos { get; set; }
        public bool Aceitou_Cookies { get; set; }
        public UsuarioStatus Status { get; set; }
    }

    public class UsuarioStatus
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
