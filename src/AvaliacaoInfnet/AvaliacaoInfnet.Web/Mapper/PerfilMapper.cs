using AvaliacaoInfnet.Domain;
using AvaliacaoInfnet.Web.Models;

namespace AvaliacaoInfnet.Web.Mapper
{
    public class PerfilMapper
    {
        public static Perfil ExtractFromViewModel(PerfilViewModel viewModel)
        {
            var perfil = new Perfil
            {
                Descricao = viewModel.Descricao,
                Status = viewModel.Status,
            };
            return perfil;
        }

        public static PerfilViewModel BuildViewModelFrom(Perfil perfil)
        {
            var viewModel = new PerfilViewModel(perfil.Id)
            {
                Descricao = perfil.Descricao,
                Status = perfil.Status,
            };

            return viewModel;
        }

    }
}