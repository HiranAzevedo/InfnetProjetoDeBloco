using CourseRating.Domain.Entities;
using System;

namespace CourseRating.Domain.Interfaces.Repositories
{
    interface IUsuarioRepository : IRepositoryBase<Usuario>, IDisposable
    {
    }
}
