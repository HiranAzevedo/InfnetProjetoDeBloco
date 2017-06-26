using AvaliacaoInfnet.Domain.Interfaces;
using AvaliacaoInfnet.Domain.Interfaces.Service;

namespace AvaliacaoInfnet.Domain.Services
{
    public class PerguntaService : ServiceBase<Pergunta>, IPerguntaService
    {
        public PerguntaService(IRepositoryBase<Pergunta> repository) : base(repository)
        {
        }
    }
}
