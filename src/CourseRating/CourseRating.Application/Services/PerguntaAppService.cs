using CourseRating.Application.Interface;
using CourseRating.Domain.Entities;
using CourseRating.Domain.Interfaces.Services;

namespace CourseRating.Application.Services
{
    public class PerguntaAppService : AppServiceBase<Pergunta>, IPerguntaAppService
    {
        private readonly IPerguntaService PerguntaService;

        public PerguntaAppService(IPerguntaService serviceBase) : base(serviceBase)
        {
            PerguntaService = serviceBase;
        }
    }
}
