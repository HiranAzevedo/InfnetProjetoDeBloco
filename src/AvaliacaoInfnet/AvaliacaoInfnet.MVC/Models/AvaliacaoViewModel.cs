﻿using AvaliacaoInfnet.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AvaliacaoInfnet.MVC.Models
{
    public class AvaliacaoViewModel
    {
        [Required]
        public string Descricao { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public bool Status { get; set; }
        [Required]
        public DateTime DataInicio { get; set; }
        [Required]
        public DateTime DataFim { get; set; }
        [Required]
        public virtual Perfil Perfil { get; set; }
        [Required]
        public virtual ICollection<Pergunta> Perguntas { get; set; }
    }
}