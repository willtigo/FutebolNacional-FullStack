using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutebolNacional.Models
{
    public class LinhaTabela
    {
        public string Nome { get; set; }
        public int Jogos { get; set; }
        public int Vitorias { get; set; }
        public int Empates { get; set; }
        public int Derrotas { get; set; }
        public int GolsFeitos { get; set; }
        public int GolsSofridos { get; set; }
        public int Saldo => GolsFeitos - GolsSofridos;
        public int Pontos => (Vitorias * 3) + Empates;

        public double Aproveitamento => Jogos > 0
        ? Math.Round((double)Pontos / (Jogos * 3) * 100, 1)
    :   0;
    }
}
