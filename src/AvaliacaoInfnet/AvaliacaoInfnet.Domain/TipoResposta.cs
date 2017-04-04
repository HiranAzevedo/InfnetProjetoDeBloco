using System.Collections.Generic;

namespace AvaliacaoInfnet.Domain
{
    public class TipoResposta
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public bool Status { get; set; }

        //relaciomamentos

        public virtual ICollection<Pergunta> Perguntas { get; set; }

        public virtual ICollection<AvaliacaoResposta> AvaliacaoRespostas { get; set; }
    }
}
