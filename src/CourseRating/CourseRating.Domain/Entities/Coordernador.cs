using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRating.Domain.Entities
{
    public class Coordernador : Usuario
    {
        public string Matricula { get; set; }

        public ICollection< Curso> Cursos { get; set; }
    }
}
