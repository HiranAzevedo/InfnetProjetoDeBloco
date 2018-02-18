namespace CourseRating.Domain.Entities
{
    public class AvaliacaoResposta
    {
        public Pergunta Pergunta { get; set; }
        public TipoResposta TipoResposta { get; set; }
        public Aluno Aluno { get; set; }
    }
}
