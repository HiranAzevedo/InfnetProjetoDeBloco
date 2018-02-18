using CourseRating.Domain.Entities;
using CourseRating.Domain.Interfaces.Repositories;
using CourseRating.Domain.Interfaces.Services;

namespace CourseRating.Domain.Services
{
    public class CoordernadorService : ServiceBase<Coordernador>, ICoordernadorService
    {
        private readonly ICoordernadorRepository CoordernadorRepository;

        public CoordernadorService(ICoordernadorRepository repository) : base(repository)
        {
            CoordernadorRepository = repository;
        }
    }
}
