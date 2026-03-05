using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutebolNacional.Models
{
    public class EstatisticaClube
    {
        public string Nome { get; set; }
        public string Sigla => Nome.Substring(0, 3).ToUpper();
        public int GolsFeitos { get; set; }
        public int GolsSofridos { get; set; }
        public int Saldo => GolsFeitos - GolsSofridos;
        public int PosicaoAtaque { get; set; }
        public string MelhorArtilheiro { get; set; } = "N/A";
        public int GolsArtilheiro { get; set; }
        public int Amarelos { get; set; }
        public int Vermelhos { get; set; }
        public bool ExibirDetalhes { get; set; }

        // Métodos de cálculo de porcentagem (Proporção Real do Campeonato)
        public double GetPorcentagemFeitos(int totalGolsCampeonato)
        {
            if (totalGolsCampeonato == 0) return 0;
            // Removi o multiplicador * 5 para testarmos a proporção REAL primeiro
            return ((double)GolsFeitos / totalGolsCampeonato) * 100;
        }

        public double GetPorcentagemSofridos(int totalGolsCampeonato)
        {
            if (totalGolsCampeonato == 0) return 0;
            return ((double)GolsSofridos / totalGolsCampeonato) * 100;
        }

    }
}
