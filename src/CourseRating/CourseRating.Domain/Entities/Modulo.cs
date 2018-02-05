using System.Collections.Generic;

namespace CourseRating.Domain.Entities
{
    public class Modulo
    {
        public string Id { get; set; }

        public string Descricao { get; set; }

        public bool Status { get; set; }

        public Turma Turma { get; set; }

    }
}