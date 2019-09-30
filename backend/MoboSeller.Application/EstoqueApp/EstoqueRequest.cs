using Flunt.Notifications;
using Flunt.Validations;

namespace MoboSeller.Application.EstoqueApp
{
    public class ObterRequest : Notifiable
    {
        public string Loja { get; set; }
        public string Codigo { get; set; }
        public string NomeProduto { get; set; }
        public string NomeCor { get; set; }
        public string Tamanho { get; set; }
        public string Familia { get; set; }

        public void Validate()
        {
            AddNotifications(new Contract()
                
                .HasMaxLen(Loja ?? string.Empty, 4, "Loja", "Deve ser informado no maximo 4 caracteres")

                .HasMaxLen(Codigo ?? string.Empty, 20, "Codigo", "Deve ser informado no máximo 12 caracteres")

                .HasMaxLen(Tamanho ?? string.Empty, 2, "Familia", "Deve ser informado no máximo 2 caracteres")

                .HasMaxLen(Familia ?? string.Empty, 3, "Familia", "Deve ser informado no máximo 3 caracteres")
            );
        }
    }
}
