using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    internal interface ISearch
    {
        public Auto SearchAuto(List<Auto> autoList);
        public List<Auto> FilterAuto(List<Auto> autoList, int year, Transmission transmission, string engine, int seats, Fuel fuel, int engineCapacity, int fuelConsumption, string brand, int mileage, int cost);

    }
}
