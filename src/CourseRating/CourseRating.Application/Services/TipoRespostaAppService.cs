using CourseRating.Application.Interface;
using CourseRating.Domain.Entities;
using CourseRating.Domain.Interfaces.Services;

namespace CourseRating.Application.Services
{
    public  class TipoRespostaAppService : AppServiceBase<TipoResposta>, ITipoRespostaAppService
    {
        private readonly ITipoRespostaService TipoRespostaService;

        public TipoRespostaAppService(ITipoRespostaService serviceBase) : base(serviceBase)
        {
            TipoRespostaService = serviceBase;
        }
    }
  
}
