using CarMicroservice.Common.Domain.Interfaces.Repositories;
using System;

namespace CarMicroservice.Domain.AggregatesModel.CarAggregate
{
    public interface ICarRepository : IRepository<Guid, Car>
    {
    }
}
