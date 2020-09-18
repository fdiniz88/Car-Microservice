using CarMicroservice.Common.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarMicroservice.Domain.AggregatesModel.CarAggregate
{
    public interface ICarService
    {        
        Task<IEnumerable<Car>> GetCars();
        Task<Car> GetCar(Guid id);
        Task<ReturnResultDto> PutCar(Guid id, Car car);
        Task<ReturnResultDto> PostCar(Car car);
        Task<ReturnResultDto> DeleteCar(Guid id);
    }
}
