using AvaliacaoInfnet.Domain.Interfaces;
using AvaliacaoInfnet.Domain.Interfaces.Service;

namespace AvaliacaoInfnet.Domain.Services
{
    public class EntrevistadoService : ServiceBase<Entrevistado>, IEntrevistadoService
    {
        public EntrevistadoService(IRepositoryBase<Entrevistado> repository) : base(repository)
        {
        }
    }
}
