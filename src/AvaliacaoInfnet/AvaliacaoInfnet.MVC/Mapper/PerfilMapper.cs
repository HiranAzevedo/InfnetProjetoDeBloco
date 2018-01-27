using AvaliacaoInfnet.Domain;
using AvaliacaoInfnet.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AvaliacaoInfnet.MVC.Mapper
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
            var viewModel = new PerfilViewModel
            {
                Descricao = perfil.Descricao,
                Status = perfil.Status,
            };

            return viewModel;
        }

    }
}