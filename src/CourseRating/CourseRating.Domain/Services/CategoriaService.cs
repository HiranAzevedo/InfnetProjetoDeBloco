using CourseRating.Domain.Entities;
using CourseRating.Domain.Interfaces.Repositories;
using CourseRating.Domain.Interfaces.Services;

namespace CourseRating.Domain.Services
{
    public class CategoriaService : ServiceBase<Categoria>, ICategoriaService
    {
        private readonly ICategoriaRepository CategoriaRepository;

        public CategoriaService(ICategoriaRepository repository) : base(repository)
        {
            CategoriaRepository = repository;
        }
    }
}
