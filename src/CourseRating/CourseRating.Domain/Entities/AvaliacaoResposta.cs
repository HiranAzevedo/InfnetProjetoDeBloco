using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRating.Domain.Entities
{
    public class AvaliacaoResposta
    {
        public Pergunta Pergunta { get; set; }
        public TipoResposta TipoResposta { get; set; }
        public Aluno Aluno { get; set; }
    }
}
