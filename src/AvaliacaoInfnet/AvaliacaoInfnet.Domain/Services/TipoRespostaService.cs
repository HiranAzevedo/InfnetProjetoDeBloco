using AvaliacaoInfnet.Domain.Interfaces;
using AvaliacaoInfnet.Domain.Interfaces.Service;

namespace AvaliacaoInfnet.Domain.Services
{
    public class TipoRespostaService : ServiceBase<TipoResposta>, ITipoRespostaService
    {
        public TipoRespostaService(IRepositoryBase<TipoResposta> repository) : base(repository)
        {
        }
    }
}
