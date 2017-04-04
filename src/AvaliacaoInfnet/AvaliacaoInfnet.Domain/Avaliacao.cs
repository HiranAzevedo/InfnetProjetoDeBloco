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

        public int? IdPerfil { get; set; }
        public virtual Perfil Perfil { get; set; }

        public virtual ICollection<Pergunta> Perguntas { get; set; }

        public virtual ICollection<AvaliacaoResposta> Respostas { get; set; }

        public virtual ICollection<Respondente> Respondentes { get; set; }

        public Avaliacao(Perfil perfil, ICollection<Pergunta> perguntas)
        {
            Perfil = perfil;
            Perguntas = perguntas;
        }

        public ICollection<AvaliacaoResposta> ObterRespostasByRespondete(int id)
        {
            return Respostas.Where(x => x.IdRespondente == id).ToList();
        }
    }
}
