using AvaliacaoInfnet.Domain.Interfaces;
using AvaliacaoInfnet.Domain.Interfaces.Service;

namespace AvaliacaoInfnet.Domain.Services
{
    public class PerfilService : ServiceBase<Perfil>, IPerfilService
    {
        public PerfilService(IRepositoryBase<Perfil> repository) : base(repository)
        {
        }
    }
}
