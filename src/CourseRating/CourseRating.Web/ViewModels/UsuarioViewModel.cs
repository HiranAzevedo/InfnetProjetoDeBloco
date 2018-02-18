using System.ComponentModel.DataAnnotations;

namespace CourseRating.Web.ViewModels
{
    public class UsuarioViewModel
    {
        [Required]
        public string Cpf { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Telefone { get; set; }
        [Required]
        public string Sexo { get; set; }
    }
}