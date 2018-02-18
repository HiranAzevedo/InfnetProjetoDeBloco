using CourseRating.Application.Interface;
using CourseRating.Domain.Entities;
using CourseRating.Domain.Interfaces.Services;

namespace CourseRating.Application.Services
{
    public class CoordernadorAppService : AppServiceBase<Coordernador>, ICoordernadorAppService
    {
        private readonly ICoordernadorService CoordernadorService;

        public CoordernadorAppService(ICoordernadorService serviceBase) : base(serviceBase)
        {
            CoordernadorService = serviceBase;
        }
    }
}
