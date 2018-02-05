using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
