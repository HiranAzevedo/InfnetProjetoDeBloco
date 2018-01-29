using AvaliacaoInfnet.Domain;
using AvaliacaoInfnet.Web.Models;
using System.Collections.Generic;
using System.Linq;

namespace AvaliacaoInfnet.Web.Mapper
{
    public class EntrevistadoMapper
    {
        public static Entrevistado ExtractFromViewModel(EntrevistadoViewModel viewModel)
        {
            var entrevistado = new Entrevistado
            {
                Id = viewModel.Id,
                Email = viewModel.Email,
                Nome = viewModel.Nome,
                Status = viewModel.Status,
                //Telefone = viewModel.Telefone,
                //Senha = viewModel.Senha,
            };

            return entrevistado;
        }

        public static EntrevistadoViewModel BuildViewModelFrom(Entrevistado entrevistado, Dictionary<int, string> AvaliablePerfis)
        {
            var viewModel = new EntrevistadoViewModel(entrevistado.Id)
            {
                Email = entrevistado.Email,
                Nome = entrevistado.Nome,
                //Senha = entrevistado.Senha,
                //Telefone = entrevistado.Telefone,
                Status = entrevistado.Status,
                PerfilOptions = AvaliablePerfis,
                SelectedPerfis = entrevistado.Perfil.Select(x => x.Id).ToList(),
            };

            return viewModel;
        }
    }
}