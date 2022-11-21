using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    public abstract class Auto
    {
        public string Name { get; set; }
        public int Year { get; set; }
        Transmission Transmission { get; set; } //коробка передач
        string Engine { get; set; }
        int Seats { get; set; }
        Fuel Fuel { get; set; }
        int EngineCapacity { get; set; }
        int FuelConsumption { get; set; }
        string Brand { get; set; }
        int Mileage { get; set; }
        public int Cost { get; private set; }
        bool IsBooking { get; set; }

        public Auto(string name, int year, Transmission transmission, string engine, int seats, Fuel fuel, int engineCapacity, int fuelConsumption, string brand, int mileage, int cost, bool isBooking)
        {
            Name = name;
            Year = year;
            Transmission = transmission;
            Engine = engine;
            Seats = seats;
            Fuel = fuel;
            EngineCapacity = engineCapacity;
            FuelConsumption = fuelConsumption;
            Brand = brand;
            Mileage = mileage;
            Cost = cost;
            IsBooking = isBooking;
        }

        public void ToBook()
        {
            // if (IsBooking == true)
            // throw new Exception("Данная машина ранее была забронирована на эту дату");
            IsBooking = true;

        }

        public void UnBook()
        {
            IsBooking = false;
        }

        public void ChangePrice(int newCost)
        {
            Cost = newCost;
        }
        public virtual string GetInfo()
        {
            return $"Данные об автомобиле: {Name}\nГод: {Year}\nТрансмиссия: {Transmission}\nДвигатель: {Engine}\nМест: {Seats}\nТип топлива: {Fuel}\nЦена: {Cost}\n";
        }

    }

    public enum Transmission
    {
        Механическая,
        Автоматическая,
        Роботизированная,
        Вариативная
    }
    public enum Fuel
    {
        Бензин,
        Дизель,
        Электрический
    }

}
