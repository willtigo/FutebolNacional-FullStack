using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutebolNacional.Models
{
    public class Jogo
    {
        public long Id { get; set; }
        public string rodada { get; set; }
        public int ano { get; set; }
        public string TimeMandante { get; set; }
        public string TimeVisitante { get; set; }
        public int GolsMandante { get; set; }
        public int GolsVisitante { get; set; }
        public DateTime DataJogo { get; set; }
        public string Estadio { get; set; }
    }
}
