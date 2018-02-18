using System.Collections.Generic;

namespace CourseRating.Domain.Entities
{
    public  class Avaliacao
    {
        public string Id { get; set; }

        public string Descricao { get; set; }

        public string Status { get; set; }

        public ICollection<Categoria> Categorias { get; set; }
    }
}
