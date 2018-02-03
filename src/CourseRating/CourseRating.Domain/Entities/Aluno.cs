using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRating.Domain.Entities
{
   public class Aluno : Usuario
    {
        public int Matricula { get; set; }

        public List<Curso> Cursos { get; set; }
    }
}
