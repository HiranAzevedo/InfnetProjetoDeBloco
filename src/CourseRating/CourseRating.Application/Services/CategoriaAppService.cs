using CourseRating.Application.Interface;
using CourseRating.Domain.Entities;
using CourseRating.Domain.Interfaces.Services;

namespace CourseRating.Application.Services
{
    public  class CategoriaAppService : AppServiceBase<Categoria>, ICategoriaAppService
    {
        private readonly ICategoriaService CategoriaService;

        public CategoriaAppService(ICategoriaService serviceBase) : base(serviceBase)
        {
            CategoriaService = serviceBase;
        }
    }
}
