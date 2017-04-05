using System;
using System.Collections.Generic;
using System.Linq;

namespace AvaliacaoInfnet.Domain
{
    public class Avaliacao
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public string Titulo { get; set; }

        public bool Status { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataFim { get; set; }

        //Relacionamentos

        public virtual Perfil Perfil { get; set; }

        public virtual ICollection<Pergunta> Perguntas { get; set; }


        public Avaliacao(Perfil perfil, string descricao, bool status, ICollection<Pergunta> perguntas)
        {
            Perfil = perfil;
            Descricao = descricao;
            Perguntas = perguntas ?? new List<Pergunta>();
            Status = status;
        }
        
    }
}
