using System;
using CarMicroservice.Common.Infra.DataAccess;
using CarMicroservice.Domain.AggregatesModel.CarAggregate;
using Microsoft.EntityFrameworkCore;

namespace CarMicroservice.Infra.DataAccess.Model
{
    public class CarRepository : EntityFrameworkRepositoryBase<Guid, Car>, ICarRepository
    {
        public CarRepository(DbContext dbContext)
            : base(db: dbContext)
        {

        }
    }
}
