using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutebolNacional.Models
{
    public class EventosJogos
    {
        public int IdEvento { get; set; }
        public long IdPartida { get; set; }
        public int Minuto { get; set; }
        public string Tipo { get; set; }
        public string Detalhe { get; set; }
        public string Jogador { get; set; }
        public string TimeNome { get; set; }
    }
}
