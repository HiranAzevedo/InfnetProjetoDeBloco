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
                Nome = viewModel.Nome,
                Cpf = viewModel.Cpf,
                Sexo = viewModel.Sexo,
                Telefone = viewModel.Telefone,
               //TODO adicionar tipo usuario
            };
            return usuario;
        }

        public static UsuarioViewModel BuildViewModelFrom(Usuario usuario)
        {
            var viewModel = new UsuarioViewModel
            {
                Nome = usuario.Nome,
                Cpf = usuario.Cpf,
                Sexo = usuario.Sexo,
                Telefone = usuario.Telefone,
                //TODO adicionar tipo usuario
            };

            return viewModel;
        }
    }
}