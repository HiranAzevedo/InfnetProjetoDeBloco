using System.ComponentModel.DataAnnotations;

namespace AvaliacaoInfnet.Web.Models
{
    public class PerfilViewModel
    {
        public PerfilViewModel(int referenceId)
        {
            ReferenceId = referenceId;
        }

        [Required]
        public string Descricao { get; set; }

        [Required]
        public bool Status { get; set; }

        [Required]
        public readonly int ReferenceId;
    }
}