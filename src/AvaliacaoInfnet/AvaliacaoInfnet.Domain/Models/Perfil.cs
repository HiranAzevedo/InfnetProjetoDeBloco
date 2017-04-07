﻿using System.Collections.Generic;

namespace AvaliacaoInfnet.Domain
{
    public class Perfil
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public bool Status { get; set; }

        public virtual ICollection<Entrevistado> Respondentes { get; set; }

        public virtual ICollection<Avaliacao> Avaliacoes { get; set; }

        public Perfil()
        { }

        public Perfil(ICollection<Entrevistado> respondentes, ICollection<Avaliacao> avaliacoes)
        {
            Respondentes = respondentes;
            Avaliacoes = avaliacoes;
        }
    }
}