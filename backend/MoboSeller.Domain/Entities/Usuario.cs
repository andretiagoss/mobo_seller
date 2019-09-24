namespace MoboSeller.Domain.Entities
{
    public class Usuario : EntidadeBase
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Loja { get; set; }
        public bool Inativo { get; set; }
    }
}
