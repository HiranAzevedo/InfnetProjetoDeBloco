using AvaliacaoInfnet.Domain;
using AvaliacaoInfnet.Web.Models;

namespace AvaliacaoInfnet.Web.Mapper
{
    public class PerguntaMapper
    {
        public static Pergunta ExtractFromViewModel(PerguntaViewModel viewModel)
        {
            var pergunta = new Pergunta
            {
                Descricao = viewModel.Descricao,
                Status = viewModel.Status,
            };
            return pergunta;
        }

        public static PerguntaViewModel BuildViewModelFrom(Pergunta pergunta)
        {
            var viewModel = new PerguntaViewModel(pergunta.Id)
            {
                Descricao = pergunta.Descricao,
                Status = pergunta.Status,
            };

            return viewModel;
        }
    }
}