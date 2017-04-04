using System.Collections.Generic;

namespace AvaliacaoInfnet.Domain
{
    public class Perfil
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public bool Status { get; set; }

        public virtual ICollection<Respondente> Respondentes { get; set; }

        public virtual ICollection<Avaliacao> Avaliacoes { get; set; }

        public Perfil()
        { }

        public Perfil(ICollection<Respondente> respondentes, ICollection<Avaliacao> avaliacoes)
        {
            Respondentes = respondentes;
            Avaliacoes = avaliacoes;
        }
    }
}
