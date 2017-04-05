using System.Collections.Generic;

namespace AvaliacaoInfnet.Domain
{
    public class AvaliacaoResposta
    {
        public int Id { get; set; }

        public int Idperfil { get; set; }

        public int IdRespondente { get; set; }

        public int IdAvaliacao { get; set; }

        //Chave idPergunta e valor IdResposta
        Dictionary<int, int> perguntaResposta { get; set; }

    }
}
