using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRating.Domain.Entities
{
   public  class Turma
    {
        public string Id { get; set; }

        public string Descricao { get; set; }

        public bool Status { get; set; }

        public ICollection<Aluno> Alunos { get; set; }
    }
}
