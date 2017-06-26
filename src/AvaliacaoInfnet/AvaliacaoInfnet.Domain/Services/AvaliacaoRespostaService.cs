using AvaliacaoInfnet.Domain.Interfaces;
using AvaliacaoInfnet.Domain.Interfaces.Service;

namespace AvaliacaoInfnet.Domain.Services
{
    public class AvaliacaoRespostaService : ServiceBase<AvaliacaoResposta>, IAvaliacaoRespostaService
    {
        public AvaliacaoRespostaService(IRepositoryBase<AvaliacaoResposta> repository) : base(repository)
        {
        }
    }
}
