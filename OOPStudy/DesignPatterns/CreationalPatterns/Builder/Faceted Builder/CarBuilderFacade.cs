using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacetedBuilder
{
    public class CarBuilderFacade
    {
        protected Car _car { get; set; }

        public CarBuilderFacade()
        {
            _car = new Car();
        }

        public Car Build() => _car;

        public CarInfoBuilder Info => new CarInfoBuilder(_car);
        public CarAddressBuilder Built => new CarAddressBuilder(_car);
    }
}
