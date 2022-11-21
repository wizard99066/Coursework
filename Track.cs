using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    public class Track : Auto
    {
        string Coupling { get; set; } // сцепка
        public Track(string name, string coupling, int year, Transmission transmission, string engine, int seats, Fuel fuel, int engineCapacity, int fuelConsumption, string brand, int mileage, int cost, bool isBooking) : base(name, year, transmission, engine, seats, fuel, engineCapacity, fuelConsumption, brand, mileage, cost, isBooking)
        {
            Coupling = coupling;
        }

        public override string GetInfo()
        {
            return "Тип автомобиля: Грузовой \n" + base.GetInfo() + $"Сцепка: {Coupling}\n";
        }
    }
}
