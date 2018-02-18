using CourseRating.Domain.Entities;
using System;

namespace CourseRating.Domain.Interfaces.Repositories
{
    interface ITurmaRepository : IRepositoryBase<Turma>, IDisposable
    {
    }
}
