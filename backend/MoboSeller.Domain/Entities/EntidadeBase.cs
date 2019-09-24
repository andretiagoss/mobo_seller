using System;
using System.Collections.Generic;
using System.Text;

namespace MoboSeller.Domain.Entities
{
    public class EntidadeBase
    {
        public long Id { get; set; }
        public DateTime DataInclusao { get; set; }
        public DateTime DataAlteracao { get; set; }

    }
}
