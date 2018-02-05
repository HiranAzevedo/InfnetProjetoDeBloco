using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRating.Domain.Entities
{
    public class Usuario
    {
        public string Cpf { get; set; }

        public string Nome { get; set; }

        public string Telefone { get; set; }

        public string Sexo { get; set; }

        public TipoUsuario TipoUsuario { get; set; }
    }
}
