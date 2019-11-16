using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacetedBuilder
{
    public class CarAddressBuilder: CarBuilderFacade
    {
        public CarAddressBuilder(Car car)
        {
            _car = car;
        }

        public CarAddressBuilder InCity(string city)
        {
            _car.City = city;
            return this;
        }

        public CarAddressBuilder AtAddress(string address)
        {
            _car.Address = address;
            return this;
        }
    }
}
