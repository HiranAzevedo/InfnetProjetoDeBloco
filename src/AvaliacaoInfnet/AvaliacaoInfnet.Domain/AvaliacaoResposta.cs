namespace AvaliacaoInfnet.Domain
{
    public class AvaliacaoResposta
    {
        public int Id { get; set; }

        public int? IdRespondente { get; set; }
        public virtual Entrevistado Respondente { get; set; }

        public int? IdAvaliacao { get; set; }
        public virtual Avaliacao Avaliacao { get; set; }

        public int? IdPergunta { get; set; }
        public virtual Pergunta Pergunta { get; set; }

        public int? IdTipoResposta { get; set; }
        public virtual TipoResposta TipoResposta { get; set; }
    }
}
