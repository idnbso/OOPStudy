using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacetedBuilder
{
    public class CarInfoBuilder: CarBuilderFacade
    {
        public CarInfoBuilder(Car car)
        {
            _car = car;
        }

        public CarInfoBuilder WithType(string type)
        {
            _car.Type = type;
            return this;
        }

        public CarInfoBuilder WithColor(string color)
        {
            _car.Color = color;
            return this;
        }

        public CarInfoBuilder WithNumberOfDoors(int number)
        {
            _car.NumberOfDoors = number;
            return this;
        }
    }
}
