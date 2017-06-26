using AvaliacaoInfnet.Domain.Interfaces;

namespace AvaliacaoInfnet.Domain.Services
{
    public class PerguntaRespostaAvaliacaoService : ServiceBase<PerguntaRespostaAvaliacao>
    {
        public PerguntaRespostaAvaliacaoService(IRepositoryBase<PerguntaRespostaAvaliacao> repository) : base(repository)
        {
        }
    }
}
