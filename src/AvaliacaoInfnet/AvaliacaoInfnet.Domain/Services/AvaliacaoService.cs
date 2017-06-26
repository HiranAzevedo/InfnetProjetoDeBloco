using AvaliacaoInfnet.Domain.Interfaces;
using AvaliacaoInfnet.Domain.Interfaces.Service;

namespace AvaliacaoInfnet.Domain.Services
{
    public class AvaliacaoService : ServiceBase<Avaliacao>, IAvaliacaoService
    {
        public AvaliacaoService(IRepositoryBase<Avaliacao> repository) : base(repository)
        {
        }
    }
}
