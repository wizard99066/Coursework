namespace Coursework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Carsharing carsharing = new Carsharing();
                var infinityFx35 = new Car("Infinity Fx35", AutoClass.Бизнес, BodyWork.Внедорожник, Trailer.Отсутствует, 2018, Transmission.Автоматическая, "VQ35DE", 5, Fuel.Бензин, 280, 12, "Infinity", 20000, 200, false);
                var mercedesBenzGClass = new Car("Mercedes-Benz G-Class", AutoClass.Бизнес, BodyWork.Внедорожник, Trailer.Отсутствует, 2021, Transmission.Механическая, "VT10ER", 5, Fuel.Дизель, 360, 14, "Mercedes", 18000, 360, false);
                var volkswagenJetta = new Car("Volkswagen Jetta", AutoClass.Эконом, BodyWork.Хэтчбек, Trailer.Легковой, 2015, Transmission.Автоматическая, "VP49XE", 5, Fuel.Бензин, 100, 10, "Volkswagen", 65000, 100, false);
                var teslaModelS = new Car("Tesla-Model-S", AutoClass.Бизнес, BodyWork.Хэтчбек, Trailer.Отсутствует, 2017, Transmission.Автоматическая, "VT33QA", 5, Fuel.Электрический, 290, 15, "Tesla", 55000, 220, false);
                var porscheCayenne = new Car("Porsche-Cayenne", AutoClass.Средний, BodyWork.Кроссовер, Trailer.Отсутствует, 2009, Transmission.Автоматическая, "VL09PL", 5, Fuel.Бензин, 180, 12, "Porsche", 58000, 180, false);
                var renaultLoganStepway = new Car("Renault Logan Stepway", AutoClass.Эконом, BodyWork.Внедорожник, Trailer.Отсутствует, 2020, Transmission.Автоматическая, "VA44DA", 5, Fuel.Бензин, 90, 9, "Renault", 90000, 65, false);
                var renaultMaster = new Track("Renault Master", "жесткая", 2017, Transmission.Механическая, "VL09QL", 3, Fuel.Дизель, 150, 17, "Renaul", 100000, 99, false);
                var peugeotBipper = new Track("Peugeot Bipper", "жесткая", 2014, Transmission.Механическая, "VD66DA", 2, Fuel.Бензин, 100, 15, "Peugeot", 100200, 50, false);
                List<Auto> autos = new List<Auto>() { infinityFx35, mercedesBenzGClass, volkswagenJetta, teslaModelS, porscheCayenne, renaultLoganStepway, renaultMaster, peugeotBipper };
                carsharing.AddAutos(autos);//добавили автомобили в лист

                carsharing.Start();

            }
            catch (Exception e)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine($"Упс.. Что-то пошло не так :(\nОшибка: {e.Message}\n");
                Console.ResetColor();
            }

        }
    }
}