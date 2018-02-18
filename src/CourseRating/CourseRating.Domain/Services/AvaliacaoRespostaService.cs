using CourseRating.Domain.Entities;
using CourseRating.Domain.Interfaces.Repositories;
using CourseRating.Domain.Interfaces.Services;

namespace CourseRating.Domain.Services
{
    public class AvaliacaoRespostaService : ServiceBase<AvaliacaoResposta>, IAvaliacaoRespostaService
    {
        private readonly IAvaliacaoRespostaRepository AvaliacaoRespostaRepository;

        public AvaliacaoRespostaService(IAvaliacaoRespostaRepository repository) : base(repository)
        {
            AvaliacaoRespostaRepository = repository;
        }
    }
}
