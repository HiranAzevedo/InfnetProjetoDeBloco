using System;
using System.ComponentModel.DataAnnotations;

namespace AvaliacaoInfnet.MVC.Models
{
    public class AvaliacaoViewModel
    {
        //public AvaliacaoViewModel(int referenceId)
        //{
        //    ReferenceId = referenceId;
        //}

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
        
        //perfil
        //[Required]
        //public virtual Perfil Perfil { get; set; }

        ////pergunta
        //[Required]
        //public virtual ICollection<Pergunta> Perguntas { get; set; }

        //[Required]
        //public readonly int ReferenceId;
    }
}