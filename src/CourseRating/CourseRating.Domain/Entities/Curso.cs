using System.Collections;
using System.Collections.Generic;

namespace CourseRating.Domain.Entities
{
    public class Curso
    {
        public string Id { get; set; }

        public string Descricao { get; set; }

        public bool Status { get; set; }

        public Coordernador Coordernador { get; set; }

        public ICollection<Turma> Turmas { get; set; }

    }
}