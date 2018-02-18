using System.ComponentModel.DataAnnotations;

namespace CourseRating.Web.ViewModels
{
    public class TipoUsuarioViewModel
    {
        [Required]
        public bool Administrador { get; set; }
        [Required]
        public bool Respondente { get; set; }
    }
}