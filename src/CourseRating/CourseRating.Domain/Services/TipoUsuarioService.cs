using CourseRating.Domain.Entities;
using CourseRating.Domain.Interfaces.Repositories;
using CourseRating.Domain.Interfaces.Services;

namespace CourseRating.Domain.Services
{
    public  class TipoUsuarioService : ServiceBase<TipoUsuario>, ITipoUsuarioService
    {
        private readonly ITipoUsuarioRepository TipoUsuarioRepository;

        public TipoUsuarioService(ITipoUsuarioRepository repository) : base(repository)
        {
            TipoUsuarioRepository = repository;
        }
    }
}
