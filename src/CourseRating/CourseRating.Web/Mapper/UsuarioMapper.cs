using CourseRating.Domain.Entities;
using CourseRating.Web.ViewModels;

namespace CourseRating.Web.Mapper
{
    public class UsuarioMapper
    {
        public static Usuario ExtractFromViewModel(UsuarioViewModel viewModel)
        {
            var usuario = new Usuario
            {
                //TODO adicionar tipo usuario
            };
            return usuario;
        }

        public static UsuarioViewModel BuildViewModelFrom(Usuario usuario)
        {
            var viewModel = new UsuarioViewModel
            {
                //TODO adicionar tipo usuario
            };

            return viewModel;
        }
    }
}