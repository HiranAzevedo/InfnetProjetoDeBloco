using CourseRating.Application.Interface;
using CourseRating.Domain.Entities;
using CourseRating.Domain.Interfaces.Services;

namespace CourseRating.Application.Services
{
    public class TipoUsuarioAppService : AppServiceBase<TipoUsuario>, ITipoUsuarioAppService
    {
        private readonly ITipoUsuarioService TipoUsuarioService;

        public TipoUsuarioAppService(ITipoUsuarioService serviceBase) : base(serviceBase)
        {
            TipoUsuarioService = serviceBase;
        }
    }
}