using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CarMicroservice.Common.Domain.DTO;

namespace CarMicroservice.Domain.AggregatesModel.CarAggregate
{
    public class CarService : ICarService
    {
        private ICarRepository CarRepository;

        public CarService(ICarRepository CarRepository)
        {
            this.CarRepository = CarRepository;
        }      
        public async Task<Car> GetCar(Guid id)
        {            
            return await CarRepository.ReadAsync(id);
        }

        public async Task<IEnumerable<Car>> GetCars()
        {
            return await CarRepository.ReadAllAsync(); 
        }
        public async Task<ReturnResultDto> PostCar(Car car)
        {
            await CarRepository.CreateAsync(car);
            await CarRepository.SaveChangesAsync();
            ReturnResultDto ReturnResultDto = new ReturnResultDto();
            ReturnResultDto.Action = "Carro criado";
            return ReturnResultDto;
        }
        public async Task<ReturnResultDto> PutCar(Guid id, Car car)
        {
            ReturnResultDto ReturnResultDto = new ReturnResultDto();           

            Car Car = await CarRepository.ReadAsync(car.Id);

            if (Car == null)
            {
                ReturnResultDto.Inconsistencies.Add(
                    "Carro não encontrado");
            }
            else
            {
                Car.Description = car.Description;             

                CarRepository.Update(Car);
                await CarRepository.SaveChangesAsync();
                ReturnResultDto.Action = "Atualização de carro";
            }
            return ReturnResultDto;
        }
        public async Task<ReturnResultDto> DeleteCar(Guid id)
        { 
            ReturnResultDto ReturnResultDto = new ReturnResultDto();
            ReturnResultDto.Action = "Delete car";

            Car Car = await CarRepository.ReadAsync(id);
            if (Car == null)
            {
                ReturnResultDto.Inconsistencies.Add(
                    "Carro não encontrado");
            }
            else
            {
                await CarRepository.DeleteAsync(id);
                await CarRepository.SaveChangesAsync();
            }
            return ReturnResultDto;
        }  
    }
}
