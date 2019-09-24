using System;
using System.Collections.Generic;
using System.Text;

namespace MoboSeller.Application.UsuarioApp
{
    public class UsuarioResponse
    {
        public long Id { get; set; }
        public string Login { get; set; }
        public bool Inativo { get; set; }
        public string Loja { get; set; }
        public DateTime DataInclusao { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}
