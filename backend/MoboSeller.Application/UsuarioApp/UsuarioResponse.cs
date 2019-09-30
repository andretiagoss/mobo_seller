using System;

namespace MoboSeller.Application.UsuarioApp
{
    public class UsuarioResponse
    {
        public long Id { get; set; }
        public string Login { get; set; }
        public string Loja { get; set; }
        public DateTime DataInclusao { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}
