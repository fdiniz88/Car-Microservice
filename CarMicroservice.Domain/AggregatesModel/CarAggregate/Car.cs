using CarMicroservice.Common.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarMicroservice.Domain.AggregatesModel.CarAggregate
{
    public class Car : EntityBase<Guid>
    {

        [ForeignKey("CarModelId")]
        public Guid CarModelId { get; set; }
        public CarType ActionType { get; set; }
        public string Description { get; set; }        
    }
}
