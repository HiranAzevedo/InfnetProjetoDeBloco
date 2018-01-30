using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace AvaliacaoInfnet.Web.Models
{
    public class EntrevistadoViewModel
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public bool Status { get; set; }

        [Required]
        public string Telefone { get; set; }

        [Required]
        public string Senha { get; set; }

        public Dictionary<int, string> PerfilOptions { get; set; }

        [Required]
        public List<int> SelectedPerfis { get; set; }
    }
}