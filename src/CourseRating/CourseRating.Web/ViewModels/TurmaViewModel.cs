using System.ComponentModel.DataAnnotations;

namespace CourseRating.Web.ViewModels
{
    public class TurmaViewModel
    {
        [Required]
        public string Descricao { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}