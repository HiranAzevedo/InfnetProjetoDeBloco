using AvaliacaoInfnet.Application.Interface;
using AvaliacaoInfnet.Domain;

namespace AvaliacaoInfnet.Application
{
    public class EntrevistadoAppService : AppServiceBase<Entrevistado>, IEntrevistadoAppService
    {
        private readonly IEntrevistadoAppService EntrevistadoApp;

        public EntrevistadoAppService(IEntrevistadoAppService serviceBase) : base(serviceBase)
        {
            EntrevistadoApp = serviceBase;
        }
    }
}
