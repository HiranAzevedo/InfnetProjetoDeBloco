using System.ComponentModel.DataAnnotations;

namespace AvaliacaoInfnet.MVC.Models
{
    public class PerfilViewModel
    {
        [Required]
        public string Descricao { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}