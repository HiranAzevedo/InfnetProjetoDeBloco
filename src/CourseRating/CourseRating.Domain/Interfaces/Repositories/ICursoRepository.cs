using CourseRating.Domain.Entities;
using System;

namespace CourseRating.Domain.Interfaces.Repositories
{
    interface ICursoRepository : IRepositoryBase<Curso>, IDisposable
    {
    }
}
