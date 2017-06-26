using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoInfnet.Domain
{
    public class PerguntaRespostaAvaliacao
    {
        public int IdAvalicao { get; set; }

        public int IdPergunta { get; set; }

        public int IdTipoResposta { get; set; }
    }
}
