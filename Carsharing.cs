namespace Coursework
{
    public class Carsharing
    {
        List<Auto> autoList = new List<Auto>();
        List<Booking> bookingList = new List<Booking>();
        public void AddAutos(List<Auto> autos)
        {
            autoList.AddRange(autos);
        }

        public List<Auto> FilterAuto(int year, int year2, int cost, int cost2)
        {
            var auto = autoList.Where(r => r.Year >= year && r.Year <= year2 && r.Cost >= cost && r.Cost <= cost2).ToList();
            return auto;
        }

        public Auto SearchAuto(string model)
        {
            var auto = autoList.FirstOrDefault(r => r.Name.ToLower() == model);
            //autoList.Find(r => r.Name == model);
            return auto;
        }
        public void GetAllAuto()
        {
            autoList.ForEach(r => Console.WriteLine(r.GetInfo()));
        }

        public void ToBook()
        {
            Console.WriteLine("Бронирование автомобиля");
            Console.WriteLine("Введите имя: ");
            string fullName = Console.ReadLine().ToLower();
            Console.WriteLine("Введите телефон: ");
            long phone = long.Parse(Console.ReadLine());
            Console.WriteLine("Введите город: ");
            string city = Console.ReadLine().ToLower();
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите модель автомобиля: ");
                    string modelCar = Console.ReadLine().ToLower();

                    var auto = SearchAuto(modelCar);
                    if (auto == null)
                        throw new Exception("Данная машина отсутствует");

                    Console.WriteLine("Введите дату выдачи: ");
                    string dateOfIssue = Console.ReadLine();
                    Console.WriteLine("Введите дату возврата: ");
                    string returnDate = Console.ReadLine();

                    var date = CheckDate(dateOfIssue, returnDate);

                    Booking booking = new Booking(date[0], date[1], city, fullName, phone, auto);
                    booking.ToBook(booking, bookingList);
                    bookingList.Add(booking);

                    Console.WriteLine("Хотите ли забронировать еще одну машину? 1-да, 0-нет: ");
                    var answer = int.Parse(Console.ReadLine());
                    if (answer == 0)
                        break;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public DateTime[] CheckDate(string date1, string date2)
        {
            DateTime dateOfIssue;
            DateTime returnDate;
            if (!DateTime.TryParse(date1, out dateOfIssue) || !DateTime.TryParse(date2, out returnDate))
                throw new Exception("Дата введена некорректно");
            if (dateOfIssue < DateTime.Now)
                throw new Exception("Выбранная вами дата уже прошла");
            if (dateOfIssue > returnDate)
                throw new Exception("Дата возврата не может быть меньше даты выдачи");
            return new[] { dateOfIssue, returnDate };

        }
        public void Start()
        {
            Console.WriteLine("Добро пожаловать!");
            bool pr = true;
            while (pr)
            {
                try
                {
                    Console.WriteLine("Что вы хотите сделать? \n0-Выйти \n1-Забронировать автомобиль \n2-Посмотреть список автомобилей");
                    var answer = int.Parse(Console.ReadLine());
                    switch (answer)
                    {
                        case (int)Answer.Exit:
                            Console.WriteLine("Всего доброго!");
                            pr = false;
                            break;
                        case (int)Answer.BookingAuto:
                            ToBook();
                            break;
                        case (int)Answer.GetAllAuto:
                            GetAllAuto();
                            break;
                        default:
                            Console.WriteLine("Такого варианта нет");
                            break;

                    }
                }
                catch (Exception e)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Ошибка: {e.Message}\n");
                    Console.ResetColor();
                }
            }
        }
    }

    public enum Answer
    {
        Exit,
        BookingAuto,
        GetAllAuto
    }
}