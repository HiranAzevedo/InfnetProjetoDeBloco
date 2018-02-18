using CourseRating.Domain.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CourseRating.Web.ViewModels
{
    public class PerguntaViewModel
    {
        [Required]
        public string Descricao { get; set; }
        [Required]
        public bool Status { get; set; }

        //Tipo resposta
        [Required]
        public Dictionary<TipoResposta, bool> TipoRespostas { get; set; }
    }
}