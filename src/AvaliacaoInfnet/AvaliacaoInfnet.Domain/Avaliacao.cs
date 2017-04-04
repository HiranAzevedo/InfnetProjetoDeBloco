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

        public virtual ICollection<Entrevistado> Entrevistado { get; set; }

        public Avaliacao(Perfil perfil, ICollection<Pergunta> perguntas, ICollection<Entrevistado> entrevistados)
        {
            Perfil = perfil;
            Perguntas = perguntas ?? new List<Pergunta>();
            Entrevistado = entrevistados ?? new List<Entrevistado>();
        }

        public ICollection<AvaliacaoResposta> ObterRespostasByRespondete(int id)
        {
            return Respostas.Where(x => x.IdRespondente == id).ToList();
        }

        public bool AdicionarRespondenteNaAvaliacao(Entrevistado respondente)
        {
            if (respondente.IdPerfil == IdPerfil)
            {
                Entrevistado.Add(respondente);
                return true;
            }

            return false;
        }
    }
}
