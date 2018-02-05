using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRating.Domain.Entities
{
    public class Pergunta
    {
        public string Id { get; set; }

        public string Descricao { get; set; }

        public bool Status { get; set; }

        public ICollection<TipoResposta> TipoRespostas { get; set; }

        public ICollection<Categoria> Categorias { get; set; }
    }
}
