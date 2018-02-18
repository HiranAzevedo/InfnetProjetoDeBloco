using CourseRating.Domain.Entities;
using CourseRating.Domain.Interfaces.Repositories;
using CourseRating.Domain.Interfaces.Services;

namespace CourseRating.Domain.Services
{
    public class TipoRespostaService : ServiceBase<TipoResposta>, ITipoRespostaService
    {
        private readonly ITipoRespostaRepository TipoRespostaRepository;

        public TipoRespostaService(ITipoRespostaRepository repository) : base(repository)
        {
            TipoRespostaRepository = repository;
        }
    }
}
