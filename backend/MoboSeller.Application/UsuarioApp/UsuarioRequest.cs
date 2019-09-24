using Flunt.Notifications;
using Flunt.Validations;

namespace MoboSeller.Application.UsuarioApp
{
    public class AutenticarRequest : Notifiable
    {
        public string Login { get; set; }
        public string Senha { get; set; }

        public void Validate()
        {
            AddNotifications(new Contract()
                .HasMinLen(Login ?? string.Empty, 1, "Login", "Deve ser informado no minimo 1 caracter")
                .HasMaxLen(Login ?? string.Empty, 20, "Login", "Deve ser informado no maximo 20 caracteres")

                .HasMinLen(Senha ?? string.Empty, 6, "Senha", "Deve ser informado no minimo 6 caracteres")
                .HasMaxLen(Senha ?? string.Empty, 20, "Senha", "Deve ser informado no máximo 20 caracteres")
            );
        }
    }
}
