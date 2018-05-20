using System.ComponentModel.DataAnnotations;

namespace CourseRating.Web.ViewModels
{
    public class TurmaViewModel
    {
        [Required]
        public int Matricula { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Status { get; set; }
    }
}