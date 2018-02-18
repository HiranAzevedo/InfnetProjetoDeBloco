using CourseRating.Domain.Entities;
using CourseRating.Domain.Interfaces.Repositories;
using CourseRating.Domain.Interfaces.Services;

namespace CourseRating.Domain.Services
{
    class PerguntaService : ServiceBase<Pergunta>, IPerguntaService
    {
        private readonly IPerguntaRepository PerguntaRepository;

        public PerguntaService(IPerguntaRepository repository) : base(repository)
        {
            PerguntaRepository = repository;
        }
    }
}
