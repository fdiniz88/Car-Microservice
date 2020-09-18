using CarMicroservice.Common.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarMicroservice.Domain.AggregatesModel.CarAggregate
{
    public class CarModel : EntityBase<Guid>
    {        
        public string Description { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}