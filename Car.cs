using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    class Car : Auto
    {
        AutoClass AutoClass { get; set; }
        BodyWork BodyWork { get; set; } //тип кузова

        Trailer Trailer { get; set; }//прицеп

        public Car(string name, AutoClass autoClass, BodyWork bodyWork, Trailer trailer, int year, Transmission transmission, string engine, int seats, Fuel fuel, int engineCapacity, int fuelConsumption, string brand, int mileage, int cost, bool isBooking) : base(name, year, transmission, engine, seats, fuel, engineCapacity, fuelConsumption, brand, mileage, cost, isBooking)
        {
            AutoClass = autoClass;
            BodyWork = bodyWork;
        }
        public override string GetInfo()
        {
            return $"Тип автомобиля: Легковой\n" + $"Класс авомобиля: {AutoClass} \n" + base.GetInfo() + $"Тип кузова: {BodyWork}\n";
        }

    }
    public enum BodyWork
    {
        Хэтчбек,
        Лифтбек,
        Внедорожник,
        Кроссовер,
        Лимузин
    }
    public enum Trailer
    {
        Бортовой,
        Самосвальный,
        Легковой,
        Отсутствует
    }
    public enum AutoClass
    {
        Бизнес,
        Средний,
        Эконом
    }

}