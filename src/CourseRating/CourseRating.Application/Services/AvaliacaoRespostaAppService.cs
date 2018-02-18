using CourseRating.Application.Interface;
using CourseRating.Domain.Entities;
using CourseRating.Domain.Interfaces.Services;

namespace CourseRating.Application.Services
{
    public class AvaliacaoRespostaAppService : AppServiceBase<AvaliacaoResposta>, IAvaliacaoRespostaAppService
    {
        private readonly IAvaliacaoRespostaService AvaliacaoRespostaService;

        public AvaliacaoRespostaAppService(IAvaliacaoRespostaService serviceBase) : base(serviceBase)
        {
            AvaliacaoRespostaService = serviceBase;
        }
    }
}
