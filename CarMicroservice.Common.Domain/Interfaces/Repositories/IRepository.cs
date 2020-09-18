using System;
using System.Collections.Generic;
using System.Text;

namespace CarMicroservice.Common.Domain.Interfaces.Repositories
{
    public interface IRepository<TKey,T> : IQueryRepository<TKey,T>, ICommandRepository<TKey,T>
    {
    }
}
