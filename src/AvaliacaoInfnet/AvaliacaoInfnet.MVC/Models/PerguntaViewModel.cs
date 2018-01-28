using System.ComponentModel.DataAnnotations;

namespace AvaliacaoInfnet.MVC.Models
{
    public class PerguntaViewModel
    {
        public PerguntaViewModel(int referenceId)
        {
            this.ReferenceId = referenceId;
        }

        [Required]
        public string Descricao { get; set; }

        [Required]
        public bool Status { get; set; }

        [Required]
        public readonly int ReferenceId;
    }
}